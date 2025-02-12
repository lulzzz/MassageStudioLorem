﻿namespace MassageStudioLorem.Services.Appointments
{
    using System;
    using System.Collections.Generic;

    using Models;

    public interface IAppointmentsService
    {
        BookAppointmentServiceModel GetTheMasseurSchedule
            (string masseurId, string massageId);

        DateTime TryToParseDate(string dateAsString, string hourAsString);

        string CheckIfMasseurUnavailableAndGetErrorMessage
        (DateTime appointmentDateTime, string hourAsString, string masseurId);

        string CheckIfClientBookedTooManyMassagesInTheSameDay
            (DateTime date, string userId);

        bool CheckIfClientTryingToBookAPastTime
            (DateTime clientCurrentDateTime, DateTime appointmentDateTime);

        void AddNewAppointment
        (string userId, 
         string masseurId, 
         string massageId,
         DateTime date,
         string hourAsString,
         double clientTimeZoneOffset);

        IEnumerable<UpcomingAppointmentServiceModel> GetUpcomingAppointments
            (string userId);

        IEnumerable<PastAppointmentServiceModel> GetPastAppointments
            (string clientId);

        IEnumerable<MasseurUpcomingAppointmentServiceModel>
            GetMasseurUpcomingAppointments(string userId);

        CancelAppointmentServiceModel GetAppointmentDataForCancel(string appointmentId);

        bool CheckIfAppointmentIsDeletedSuccessfully(string appointmentId);
    }
}
