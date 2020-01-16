using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models
{
    public class Sportag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Sportág")]
        public string SportagNev { get; set; }
    }
}