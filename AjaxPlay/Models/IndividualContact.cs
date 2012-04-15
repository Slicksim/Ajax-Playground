using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class IndividualContact : Contact
    {
        [Required]
        [Range(1, 99)]
        public int FirmId { get; set; }

        public Firm Firm { get; set; }
    }
}