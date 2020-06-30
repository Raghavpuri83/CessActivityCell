using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CessActivityCell.Models;

namespace CessActivityCell.Models
{
    public class RegistrationsViewModel
    {
        public List<Registration> Registrations { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}