﻿namespace MassageStudioLorem.Controllers
{
    using System;
    using System.Globalization;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure;
    using Models.Appointments;
    using Services.Appointments;
    using Services.Appointments.Models;

    using static Global.GlobalConstants.ErrorMessages;
    using static Areas.Client.ClientConstants;

    [Authorize(Roles = ClientRoleName)]
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentsService _appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
            => this._appointmentsService = appointmentsService;

        public IActionResult Index()
        {
            var userId = this.User.GetId();

            var upcomingAppointmentsModels = 
                this._appointmentsService.GetUpcomingAppointments(userId);

            var pastAppointments = this._appointmentsService
                .GetPastAppointments(userId);

            return this.View(new AppointmentsListViewModel()
            {
                UpcomingAppointments = upcomingAppointmentsModels,
                PastAppointments = pastAppointments
            });
        }

        public IActionResult CancelAppointment(string appointmentId)
        {
            var cancelAppointmentModel = this._appointmentsService
                .GetAppointment(appointmentId);

            if (CheckIfNull(cancelAppointmentModel))
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return this.View(cancelAppointmentModel);
        }

        [HttpPost]
        public IActionResult Delete(string appointmentId)
        {
            if (!this._appointmentsService
                .CheckIfAppointmentIsDeletedSuccessfully(appointmentId))
            {
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return this.View("CancelAppointment", null);
            }

            return this.RedirectToAction("Index");
        }

        public IActionResult Book([FromQuery] AppointmentIdsQueryModel query)
        {
            var appointmentModel =
                this._appointmentsService
                    .GetTheMasseurSchedule(query.MasseurId, query.MassageId);

            if (CheckIfNull(appointmentModel)) 
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return this.View(appointmentModel);
        }

        [HttpPost]
        public IActionResult Book(BookAppointmentServiceModel query)
        {
            var cultureInfo = CultureInfo.GetCultureInfo("bg-BG");

            var clientCurrentDateTime =
                DateTime.Parse(query.ClientCurrentDateTime, cultureInfo);

            var massageId = query.MassageId;
            var masseurId = query.MasseurId;
            var userId = this.User.GetId();

            if (!this.ModelState.IsValid)
                return this.RedirectToAction
                ("Book", new {massageId, masseurId});

            var hour = query.Hour.Trim();
            var date = this._appointmentsService.ParseDate(query.Date, hour);

            //var exceededBookedMassagesMessage = this._appointmentsService
            //    .CheckIfClientBookedTooManyMassagesInTheSameDay(date, userId);

            //if (!CheckIfNull(exceededBookedMassagesMessage))
            //{
            //    this.ModelState.AddModelError
            //        (String.Empty, exceededBookedMassagesMessage);

            //    return this.View(null);
            //}

            if (this._appointmentsService.CheckIfClientTryingToBookAPastTime
                (clientCurrentDateTime, date))
            {
                this.ModelState.AddModelError(String.Empty, CannotBookInThePast);

                return this.View(null);
            }

            var availableHoursMessage =
                this._appointmentsService.
                    CheckIfMasseurUnavailableAndGetErrorMessage
                        (date, hour, masseurId);

            if (!CheckIfNull(availableHoursMessage))
            {
                this.ModelState.AddModelError
                    (String.Empty, availableHoursMessage);

                return this.View(query);
            }

            this._appointmentsService.AddNewAppointment
                (userId, masseurId, massageId, date, hour);

            return this.RedirectToAction("Index");
        }

        private static bool CheckIfNull(object obj)
            => obj == null;
    }
}