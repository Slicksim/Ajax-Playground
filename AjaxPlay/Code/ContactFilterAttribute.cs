using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPlay.Models;

namespace AjaxPlay.Code
{
    public class ContactFilterAttribute : ActionFilterAttribute
    {
        private IList<ContactFilter> _filters;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _filters = filterContext.HttpContext.Session["Filters"] as IList<ContactFilter> ?? new List<ContactFilter>();

            filterContext.ActionParameters["filters"] = _filters;
            
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Session["filters"] = _filters;

            base.OnActionExecuted(filterContext);
        }
    }
}