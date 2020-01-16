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
        public Sportag sportag { get; set; }
        public int sportagId { get; set; }

    }
}