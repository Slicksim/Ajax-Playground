using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class MyContactsFilter : ContactFilter
    {
        public int Value { get; set; }
        public override string Id { get; set; }

        public MyContactsFilter()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override bool Editable
        {
            get { return false; }
        }
    }
}