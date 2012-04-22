using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AjaxPlay.Code;
using AjaxPlay.Models;

namespace AjaxPlay.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        
        public ActionResult Index(string id)
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("Index")]
        public JsonResult SaveContact(Contact contact)
        {

            if (!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("The contact has some validation errors, please correct them and try again");
            }


            return Json(contact);

        }

        [ContactFilter]
        public PartialViewResult ContactFilters(IList<ContactFilter> filters )
        {
            return PartialView(filters);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult AddMyContactFilter(IList<ContactFilter> filters)
        {                       
            if(!filters.Any(cf => cf.GetType().Name == "MyContactsFilter"))
                filters.Add(new MyContactsFilter{Value = 294});            
            return PartialView("ContactFilters", filters);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult AddContactClosedFilter(IList<ContactFilter> filters)
        {
            var filter = new ContactClosedFilter();
            if(!filters.Any(cf => cf.GetType().Name == filter.GetType().Name))
                filters.Add(filter);
            return PartialView("ContactFilters", filters);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        [ContactFilter]
        [ActionName("EditContactClosedFilter")]
        public PartialViewResult GetContactClosedFilter(IList<ContactFilter> filters)
        {
            var filter = (ContactClosedFilter)filters.First(cf => cf.GetType().Name == "ContactClosedFilter");
            return PartialView("EditorTemplates/contactClosedFilter", filter);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult EditContactClosedFilter(IList<ContactFilter> filters, ContactClosedFilter filter)
        {
            filters.Remove(filters.FirstOrDefault(cf => cf.Id == filter.Id));
            
            filters.Add(filter);
            return PartialView("DisplayTemplates/contactClosedFilter", filter);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult RemoveContactFilter(IList<ContactFilter> filters, string id)
        {
            filters.Remove(filters.FirstOrDefault(cf => cf.Id == id));
            return PartialView("ContactFilters", filters);
        }

        public IEnumerable<SelectListItem> ContactReasons()
        {
            var list = new List<SelectListItem>
                           {
                               new SelectListItem {Text = "first", Value = "1"},
                               new SelectListItem {Text = "second", Value  = "2"},
                               new SelectListItem {Text = "third", Value = "3"}
                           };

            return list;
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult AddContactReasonFilter(IList<ContactFilter> filters)
        {
            var filter = new ContactReasonFilter();
            if (!filters.Any(cf => cf.GetType().Name == filter.GetType().Name))
            {
                var firstReason = ContactReasons().FirstOrDefault();
                filter.Value = int.Parse(firstReason.Value);
                filter.Description = firstReason.Text;
                filters.Add(filter);
            }
            return PartialView("ContactFilters", filters);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        [ContactFilter]
        [ActionName("EditContactReasonFilter")]
        public PartialViewResult GetContactReasonFilter(IList<ContactFilter> filters)
        {
            var filter = (ContactReasonFilter)filters.First(cf => cf.GetType().Name == "ContactReasonFilter");
            return PartialView("EditorTemplates/contactReasonFilter", filter);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ContactFilter]
        public PartialViewResult EditContactReasonFilter(IList<ContactFilter> filters, ContactReasonFilter filter)
        {
            filters.Remove(filters.FirstOrDefault(cf => cf.Id == filter.Id));
            var contactReason = ContactReasons().FirstOrDefault(cr => cr.Value == filter.Value.ToString());
            filter.Description = contactReason.Text;
            filters.Add(filter);
            return PartialView("DisplayTemplates/contactReasonFilter", filter);
        }
    }
}
