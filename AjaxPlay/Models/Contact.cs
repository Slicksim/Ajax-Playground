using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxPlay.Models
{
    public class Contact
    {

        [Key]
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Notes { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Please select a contact reason")]
        public int ContactReasonId { get; set; }

        public ContactReason ContactReason { get; set; }
    }
}