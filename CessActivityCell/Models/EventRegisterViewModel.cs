using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CessActivityCell.Models;

namespace CessActivityCell.Models
{
    public class EventRegisterViewModel
    {
        public Event Event { get; set; }
        public Registration Registration { get; set; }
    }
}