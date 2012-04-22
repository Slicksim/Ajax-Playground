using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public abstract class ContactFilter
    {
        public abstract string Id { get; set; }
        public abstract bool Editable { get; }
    }
}