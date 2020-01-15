using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class Sport
    {

        public int Id { get; set; }
        [Required]
        [Display(Name ="Sport Neve")]
        public string Nev { get; set; }
        [Required]
        [Display(Name = "Sportág")]
        public string Sportag { get; set; }

    }
}