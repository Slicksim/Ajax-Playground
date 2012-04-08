using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxPlay.Models
{
    public class FormModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}