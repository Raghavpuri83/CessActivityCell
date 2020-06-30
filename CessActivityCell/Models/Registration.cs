using System;
using System.Collections.Generic;

//For Required Property
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;
using CessActivityCell.Models;

namespace CessActivityCell.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string College { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string CurrentYear { get; set; }

        public Event Event { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}