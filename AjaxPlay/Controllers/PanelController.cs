using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPlay.Models;

namespace AjaxPlay.Controllers
{
    public class PanelController : Controller
    {
        //
        // GET: /Panel/

        public PartialViewResult Panels()
        {
            var list = new List<BasePanel>();

            list.Add(new EventsPanel());
            list.Add(new TasksPanel());

            return PartialView(list);
        }
        

    }
}
