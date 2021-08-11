﻿namespace MassageStudioLorem.Services.Reviews.Models
{
    using System;

    public class ReviewServiceModel
    {
        public string Id { get; set; }

        public string ClientFirstName { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
