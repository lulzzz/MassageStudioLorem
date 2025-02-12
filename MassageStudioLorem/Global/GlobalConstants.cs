﻿namespace MassageStudioLorem.Global
{
    public static class GlobalConstants
    {
        public static class DataValidations
        {
            public const int FirstNameMaxLength = 30;

            public const int FirstNameMinLength = 3;

            public const int PasswordMaxLength = 100;

            public const int PasswordMinLength = 6;

            public const int FullNameMaxLength = 100;

            public const int FullNameMinLength = 5;

            public const int CategoryNameMaxLength = 50;

            public const int CategoryNameMinLength = 5;

            public const int ShortDescriptionMaxLength = 300;

            public const int ShortDescriptionMinLength = 20;

            public const int LongDescriptionMaxLength = 1000;

            public const int LongDescriptionMinLength = 100;

            public const int ReviewMaxLength = 500;

            public const int ReviewMinLength = 20;

            public const int MassageNameMaxLength = 40;

            public const int MassageNameMinLength = 4;

            public const int MasseurDescriptionMaxLength = 1000;

            public const int MasseurDescriptionMinLength = 20;

            public const int DefaultHoursPerDay = 8;

            public const int MaxAmountToBookMassages = 3;

            public const double MassageMinPrice = 10.00;

            public const double MassageMaxPrice = 1000.00;

            public const string UrlRegex = @"^https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)$";

            public const string PhoneNumberRegex
                = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
        }

        public static class ErrorMessages
        {
            public const string Hour
                = "Please select a valid hour!";

            public const string Date
                = "Please select a valid date!";

            public const string FullNameLength
                = "The provided full name must be between {1} and {2} characters long!";

            public const string FirstNameLength
                = "The provided first name must be between {1} and {2} characters long!";

            public const string InvalidUrl
                = "The provided URL is invalid!";

            public const string MasseurDescriptionLength
                = "The provided description must be between {1} and {2} characters long!";

            public const string PasswordLength
                = "The provided {0} must be at least {2} and {1} characters long!";

            public const string PasswordConformation
                = "The provided password and confirmation password do not match!";

            public const string InvalidPhoneNumber
                = "The provided Phone Number is not valid or contains unnecessary white spaces!";

            public const string CategoryIdError = "Category does not exists!";

            public const string GenderIdError = "Please choose between the provided options!";
            
            public const string NoMasseursFoundUnderCategory = "No masseurs are found under this category!";

            public const string NoMasseursFound = "No masseurs are found!";

            public const string NoCategoriesFound = "No categories are found!";

            public const string NoCategoriesAndMassagesFound = "No categories and massages are found!";

            public const string NoMassagesFound = "No massages are found!";

            public const string SomethingWentWrong = "Ups... something went wrong! ¯\\_(ツ)_/¯";

            public const string NothingBookedYet = "Nothing booked yet!";

            public const string NoBookedAppointments = "Nothing booked yet! Would you like to treat yourself with a massage?";

            public const string AvailableHoursForDate = "The {0} hour is already booked for {1}! Available hours are: {2}";

            public const string MasseurBookedForTheDay = "There are no available hours for date: {0}!";

            public const string TooManyBookingsOfTheSameMassage = "You have exceeded the maximum amount of allowed booked massages ({0}) per day!";

            public const string CannotBookInThePast = "You cannot book an appointment in the past!";

            public const string ReviewLength
                = "The provided review must be at least {2} and {1} characters long!";

            public const string UserHasLeftAReview
                = "You had already left a review!";

            public const string NoReviewsFound
                = "No reviews found!";

            public const string CategoryNameLength
                = "The provided name must be at least {2} and {1} characters long!";

            public const string CategoryNameExists
                = "A category with the provided name already exists!";

            public const string MassageDescriptionLength
                = "The provided description must be at least {2} and {1} characters long!";

            public const string MassageNameError = "A massage with the provided name -> {0} <- already exists!";

            public const string PriceRange
                = "The provided price must be between {2} $ and {1} $!";

            public const string MassageNameLength
                = "The provided name must be at least {2} and {1} characters long!";
        }

        public static class DateTimeFormats
        {
            public const string DateTimeFormat = "dd-MM-yyyy";

            public const string HourFormat = "HH:mm";
        }

        public static class Paging
        {
            public const int CurrentPageStart = 1;

            public const int CategoriesPerPage = 1;

            public const int ThreeCardsPerPage = 3;

            public const int ReviewsPerPage = 10;
        }

        public static class Recommendations
        {
            public const string ImageUrl =
                "We recommend to upload it on imgur.com and then right click over the post -> Copy image address. The URL should end with .jpg / .png etc...";

            public const string ChangeCategory =
                "Please, change the masseur's category after the salon's closing hours or during the weekend!";

            public const string PerformAction =
                "Please, perform this action after the salon's closing hours or during the weekend!";
        }

        public static class Notifications
        {
            public const string UsernameLetters =
                "The letters in the username must be only in english!";

            public const string UserWillBeSignedOut =
                "If successful you will be signed out and redirected to the home page from where you can log back into your account!";

            public const string SuccessfullyBecomeMasseurKey =
                "SBMK";

            public const string SuccessfullyBecomeMasseur =
                "Thank you for joining our team of masseurs! Please, log back into your account!";

            public const string CookiesUsage = "We use cookies to improve your experience.";

            public const string SuccessfullyAddedCategoryKey =
                "SACK";

            public const string SuccessfullyAddedCategory = "Category added successfully!";

            public const string DeleteMassageWarning =
                "Deleting this massage will result in the deletion of all its past and upcoming appointments and it will be removed from its category!";

            public const string SuccessfullyDeletedMassageKey =
                "SDMK";

            public const string SuccessfullyDeletedMassage = "The massage and all its past and upcoming appointments were deleted successfully!";

            public const string SuccessfullyEditedMassageKey =
                "SEMK";

            public const string SuccessfullyEditedMassage = "The massage was edited successfully! ";

            public const string SuccessfullyAddedMassageKey =
                "SAMK";

            public const string SuccessfullyAddedMassage = "The massage was added successfully! ";

            public const string DeleteCategoryWarning =
                "Deleting this category will result in the deletion of all its massages, their appointments, reviews and all of the masseurs under this category will be removed from it!";

            public const string SuccessfullyDeletedCategoryKey =
                "SDCK";

            public const string SuccessfullyDeletedCategory = "The category and its related entities were deleted successfully! Please set a category to the masseurs which were under the deleted category!";

            public const string SuccessfullyEditedMasseurKey =
                "SEMK";

            public const string SuccessfullyEditedMasseur = "The masseur was edited successfully!";

            public const string DeleteMasseurWarning =
                "Deleting this masseur will result in the deletion of all its past and upcoming appointments and reviews!";

            public const string SuccessfullyDeletedMasseurKey =
                "SDMK";

            public const string SuccessfullyDeletedMasseur = "The masseur and its related entities were deleted successfully!";

            public const string DeleteReviewWarning =
                "Are you sure you want to delete this review?";

            public const string SuccessfullyDeletedReviewKey =
                "SDRK";

            public const string SuccessfullyDeletedReview = "The review was deleted successfully!";

            public const string SuccessfullyCanceledAppointmentKey =
                "SCAK";

            public const string SuccessfullyCanceledAppointment = "The appointment was canceled successfully!";

            public const string SuccessfullyReviewedMasseurKey =
                "SRMK";

            public const string SuccessfullyReviewedMasseur = "The masseur was successfully reviewed!";

            public const string SuccessfullyBookedAppointmentKey =
                "SBAK";

            public const string SuccessfullyBookedAppointment = "The appointment was successfully booked!";
        }
    }
}
