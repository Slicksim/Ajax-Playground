using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class FirmContact : Contact
    {
        public int ApplicationId { get; set; }

        public FirmApplication Application { get; set; }
    }
}