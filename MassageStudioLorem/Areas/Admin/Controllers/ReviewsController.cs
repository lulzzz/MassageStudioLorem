﻿namespace MassageStudioLorem.Areas.Admin.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    using MassageStudioLorem.Services.Reviews;
    using MassageStudioLorem.Services.Reviews.Models;

    using static Global.GlobalConstants.ErrorMessages;
    using static Global.GlobalConstants.Notifications;

    public class ReviewsController : AdminController
    {
        private readonly IReviewsService _reviewsService;

        public ReviewsController(IReviewsService reviewsService)
            => this._reviewsService = reviewsService;

        public IActionResult All
            ([FromQuery] AllReviewsQueryServiceModel queryModel)
        {
            var allReviewsModel = this._reviewsService
                .GetAllReviews(queryModel.CurrentPage);

            return this.View(allReviewsModel);
        }

        public IActionResult DeleteReview(string reviewId)
        {
            var reviewDataModel = this._reviewsService
                .GetReviewDataForDelete(reviewId);

            if (CheckIfNull(reviewDataModel)) 
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return this.View(reviewDataModel);
        }

        [HttpPost]
        public IActionResult Delete(string reviewId)
        {
            if (!this._reviewsService.CheckIfReviewDeletedSuccessfully(reviewId))
            {
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return this.View(nameof(this.DeleteReview));
            }

            this.TempData[SuccessfullyDeletedReviewKey] =
                SuccessfullyDeletedReview;

            return this.RedirectToAction(nameof(this.All));
        }

        private static bool CheckIfNull(object obj)
            => obj == null;
    }
}
