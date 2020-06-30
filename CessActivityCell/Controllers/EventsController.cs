using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CessActivityCell.Models;

namespace CessActivityCell.Controllers
{
    public class EventsController : Controller
    {

        private ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Events
        public ActionResult Index()
        {
            var events = _context.Events.OrderByDescending(s => s.Date).ToList();

            return View(events);
        }

        // GET: Events/Detail/<Id>
        public ActionResult Detail(int Id)
        {
            var evnt = _context.Events.SingleOrDefault(c => c.Id == Id);

            if (evnt == null)
            {
                return HttpNotFound();
            }

            return View(evnt);
        }

        // GET: Events/Register/<Id>
        public ActionResult Register(int Id)
        {
            var evnt = _context.Events.SingleOrDefault(c => c.Id == Id);

            var viewModel = new EventRegisterViewModel
            {
                Event = evnt,
                Registration = new Registration { EventId = Id}
            };

            if (evnt == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateReg(EventRegisterViewModel viewModel)
        {
            try
            {
                _context.Registrations.Add(viewModel.Registration);
                _context.SaveChanges();
                TempData["RegistrationSuccess"] = "Success";
                return RedirectToAction("Index", "Events");
            }
            catch (Exception e)
            {
                TempData["RegistrationSuccess"] = "Failed";
                return RedirectToAction("Index", "Events");
            }
            
        }

        // GET: Events/New
        [Authorize]
        public ActionResult New()
        {
            if (User.IsInRole("CanAddEvents"))
            {

                var evnt = new Event();

                return View(evnt);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult CreateEvnt(Event evnt)
        {
            try
            {
                _context.Events.Add(evnt);
                _context.SaveChanges();
                TempData["EventAdded"] = "Success";
                return RedirectToAction("Index", "Events");
            }
            catch (Exception e)
            {
                TempData["EventAdded"] = "Failed";
                return RedirectToAction("Index", "Events");
            }
        }

        // GET: Events/Calender
        public ActionResult Calendar()
        {
            return View();
        }

        // GET: Events/GetEvents
        public JsonResult GetEvents()
        {
            var events = _context.Events.ToList();
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}