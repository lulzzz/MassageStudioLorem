﻿namespace MassageStudioLorem.Tests.Data.DbModels
{
    using Microsoft.AspNetCore.Identity;

    using MassageStudioLorem.Data.Models;
    using MassageStudioLorem.Data.Enums;

    public class MasseursControllerTestDbModels
    {
        public static Category TestCategory => new()
        {
            Id = TestCategoryData.Id,
            Name = TestCategoryData.Name
        };

        public static IdentityUser TestUser => new()
        {
            Id = TestUserId,
            UserName = "TestUserUsername"
        };

        public static Client TestClient => new()
        {
            FirstName = TestClientData.FirstName,
            UserId = TestUserId,
            Id = "TestClientId"
        };

        public static IdentityRole MasseurRole => new()
        {
            Name = "Masseur",
            NormalizedName = "MASSEUR",
            Id = "MasseurRoleId"
        };

        public static Masseur TestMasseur => new()
        {
            Description = DummyDescription,
            CategoryId = TestCategoryData.Id,
            FullName = TestMasseurData.FullName,
            Gender = TestMasseurData.Gender,
            UserId = TestMasseurData.UserId,
            ProfileImageUrl = TestImageUrl,
            Id = TestMasseurData.Id
        };

        public static IdentityUser TestMasseurUser => new()
        {
            PhoneNumber = TestMasseurData.PhoneNumber,
            UserName = "MasseurUserName",
            Id = TestMasseurData.UserId
        };

        public static Massage TestMassage => new()
        {
            Id = TestMassageData.Id,
            ImageUrl = TestImageUrl,
            Price = TestMassageData.Price,
            ShortDescription = DummyDescription,
            LongDescription = DummyDescription,
            CategoryId = TestCategoryData.Id,
            Name = TestMassageData.Name
        };

        public const string DummyDescription =
           "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut leo quam, eleifend sit amet faucibus non, tempus et purus. Nullam nunc leo, varius vitae mauris ut, semper bibendum sapien. Quisque ut dapibus dolor. Nulla facilisi. Vivamus nunc mauris, pharetra eu orci in, auctor hendrerit lacus. Ut eget eros sed urna aliquet vestibulum. Morbi non lacus a mauris faucibus elementum a et quam.";

        public const string TestImageUrl = "https://i.imgur.com/9NfF4Cw.png";

        public const string HomeActionName = "Index";

        public const string HomeControllerName = "Home";

        public const string TestUserId = "TestId";

        public static class TestClientData
        {
            public const string FirstName = "TestClientFirstName";
            public const string Id = "TestClientId";
        }

        public static class TestMasseurData
        {
            public const string FullName = "Test Masseur";
            public const string UserId = "TestMasseurUserId";
            public const string Id = "TestMasseurId";
            public const string PhoneNumber = "MasseurPhoneNumber";
            public const Gender Gender = MassageStudioLorem.Data.Enums.Gender.Male;
        }

        public static class TestCategoryData
        {
            public const string Id = "TestCategoryId";

            public const string Name = "TestCategory";
        }

        public static class TestMassageData
        {
            public const string Id = "TestMassageId";

            public const string Name = "TestMassage";

            public const double Price = 60.00;
        }

        public static class TestUpcomingAppointmentData
        {
            public const string Id = "TestUpcomingAppointmentId";

            public const string Hour = "14:00";
        }

        public static class TestPastAppointmentData
        {
            public const string Id = "TestPastAppointmentId";

            public const string Hour = "09:00";

            public const string Content = "Test Review Test Review Test Review Test Review";
        }

        public static class TestClientUserData
        {
            public const string UserName = "TestUserUsername";
        }

        public static class TestMasseurUserData
        {
            public const string Id = "MasseurUserId";

            public const string UserName = "TestMasseurUserUsername";
        }

        public static class TestReviewData
        {
            public const string Id = "TestReviewId";

            public const string Content = "Test Review Test Review Test Review Test Review";
        }
    }
}
