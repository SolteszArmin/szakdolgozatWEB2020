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

        [Key,Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Sport Neve")]
        [Column(Order = 1)]
        public string Nev { get; set; }
        [ForeignKey("Sportag"), Column(Order = 2)]
        public int sportagId { get; set; }
        public virtual Sportag Sportag { get; set; }



    }
}