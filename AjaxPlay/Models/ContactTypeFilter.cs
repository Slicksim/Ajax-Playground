using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class ContactTypeFilter :ContactFilter
    {
        public override string Id { get; set; }

        public ContactTypeFilter()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override bool Editable
        {
            get { throw new NotImplementedException(); }
        }

        public int Value { get; set; }
    }
}