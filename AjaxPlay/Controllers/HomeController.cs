using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPlay.Models;

namespace AjaxPlay.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Form()
        {
            return PartialView();
        }

        public string Update(FormModel model)
        {

            return "test";
        }

    }
}
