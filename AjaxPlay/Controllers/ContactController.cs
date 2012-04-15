using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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
            
            if(!ModelState.IsValid)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("The contact has some validation errors, please correct them and try again");
            }


            return Json(contact);

        }

    }
}
