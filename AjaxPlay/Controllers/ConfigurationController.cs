using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AjaxPlay.Models;

namespace AjaxPlay.Controllers
{
    public class ConfigurationController : Controller
    {
        //
        // GET: /Configuration/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ActivityType()
        {
            var list = new List<ActivityType>
                           {
                               new ActivityType {Description = "Activity Type 1", Id = 1},
                               new ActivityType {Description = "Activity Type 2", Id = 2},
                               new ActivityType {Description = "Activity Type 3", Id = 3}
                           };
            return PartialView(list);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("ActivityType")]
        public JsonResult SaveActivityType(ActivityType activityType)
        {
            return Json("Success");
        }

        public PartialViewResult ActivityResult()
        {
            var list = new List<ActivityResult>
                           {
                               new ActivityResult {Id = 1, Description = "Activity Result 1"},
                               new ActivityResult {Id = 2, Description = "Activity Result 2"},
                               new ActivityResult {Id = 3, Description = "Activity Result 3"}
                           };

            return PartialView(list);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("ActivityResult")]
        public JsonResult SaveActivityResult(ActivityResult activityResult)
        {
            if(!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Error");
            }


            return Json("Success");
        }

        public PartialViewResult ContactReason()
        {
            var list = new List<ContactReason>
                           {
                               new ContactReason {Id = 1, Description = "Contact Reason 1"},
                               new ContactReason {Id = 2, Description = "Contact Reason 2"},
                               new ContactReason {Id = 3, Description = "Contact Reason 3"},
                               new ContactReason {Id = 4, Description = "Contact Reason 4"},
                               new ContactReason {Id = 5, Description = "Contact Reason 5"},
                               new ContactReason {Id = 6, Description = "Contact Reason 6"},
                               new ContactReason {Id = 7, Description = "Contact Reason 7"},
                               new ContactReason {Id = 8, Description = "Contact Reason 8"},
                               new ContactReason {Id = 9, Description = "Contact Reason 9"},
                               new ContactReason {Id = 10, Description = "Contact Reason 10"},
                               new ContactReason {Id = 11, Description = "Contact Reason 11"}
                           };
            return PartialView(list);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("ContactReason")]
        public JsonResult SaveContactReason(ContactReason contactReason)
        {

            return Json("Success");
        }
    }
}
