﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DevAdventCalendarCompetition.Repository.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public ICollection<TestAnswer> Answers { get; set; }
    }
}