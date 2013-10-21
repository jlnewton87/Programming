using joshnewton.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace joshnewton.net.Controllers
{
    public class GraduationController : Controller
    {
        //
        // GET: /Graduation/

        public ActionResult RSVP(string Id)
        {
            Attendee RsvpAttendee = new Attendee();
            using (GraduationEntities ents = new GraduationEntities())
            {
                RsvpAttendee = ents.Attendees.Where(x => x.UID == Id).Single();
            }
            return View("Index", RsvpAttendee);
        }

        [HttpPost]
        public void SubmitRsvp(RSVP RsvpData)
        {
            Attendee person = new Attendee();
            using (GraduationEntities ents = new GraduationEntities())
            {
                ents.RSVPs.Add(RsvpData);
                person = ents.Attendees.Where(x => x.Id == RsvpData.AttendeeId).Single();
                ents.SaveChanges();
            }
        }

        public ActionResult Thanks()
        {
            return View();
        }

    }
}
