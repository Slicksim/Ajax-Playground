using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class ContactClosedFilter : ContactFilter
    {
        public  bool Value { get; set; }
        public override string Id { get; set; }

        public ContactClosedFilter()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override bool Editable
        {
            get { return true; }
        }
    }
}