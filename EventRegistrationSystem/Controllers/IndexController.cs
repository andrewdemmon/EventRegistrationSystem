using EventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            GetEvents();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration reg)
        {
            if (ModelState.IsValid)
            {
                using (EventRegistrationSystemEntities db = new EventRegistrationSystemEntities())
                {
                    reg.RegistrationDate = DateTime.Now;

                    try
                    {
                        db.Registrations.Add(reg);
                        db.SaveChanges();
                    }
                    catch(Exception)
                    {
                        ViewBag.ErrorMessage = "An error occurred while saving the your registration";
                        return View("Error");
                    }
                }
            }
            else
            {
                GetEvents();
                
                return View();
            }
            return View("RegistrationConfirmation");
        }

        private void GetEvents()
        {
            using(EventRegistrationSystemEntities db = new EventRegistrationSystemEntities())
            {
                //ViewBag.EventList = db.Events.OrderBy(x => x.EventName).ToList();
                ViewBag.EventList = db.Events.OrderBy(x => x.EventName)
                    .Select(x=> new SelectListItem
                    {
                        Text=x.EventName,
                        Value = x.Id.ToString()
                    });
   

            }
        }

    }
}
