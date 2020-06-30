using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CessActivityCell.Models;

namespace CessActivityCell.Controllers
{
    public class RegistrationsController : Controller
    {

        private ApplicationDbContext _context;

        public RegistrationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Registrations
        [Authorize]
        public ActionResult Index()
        {
            if (User.IsInRole("CanAddEvents"))
            {

                var regs = _context.Registrations.OrderByDescending(s => s.Id).ToList();
                var evnts = _context.Events.ToList();

                var viewModel = new RegistrationsViewModel
                {
                    Registrations = regs,
                    Events = evnts
                };

                return View(viewModel);
            }
            return HttpNotFound();
        }
    }
}