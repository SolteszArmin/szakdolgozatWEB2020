using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class Sport
    {

        [Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Sport Neve")]
        [Column(Order = 1)]
        public string Nev { get; set; }

        [Key,Column(Order =2)]
        public int sportagId { get; set; }

        [ForeignKey("sportagId")]
        public virtual Sportag Sportag { get; set; }



    }
}