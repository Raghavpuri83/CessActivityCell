using System;
using System.Collections.Generic;

//For Required Property
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace CessActivityCell.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Fee { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        public string Venue { get; set; }
    }
}