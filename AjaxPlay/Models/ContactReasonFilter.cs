using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class ContactReasonFilter :ContactFilter
    {
        public override string Id { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public ContactReasonFilter()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override bool Editable
        {
            get { return true; }
        }
    }
}