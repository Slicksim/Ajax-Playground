using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class ActivityResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}