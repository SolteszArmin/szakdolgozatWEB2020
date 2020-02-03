using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Szakdoga.Models
{
    public class SportHirdetes
    {
        [Key,Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Column(Order = 1)]
        public int SportoloLetszam { get; set; }
        [Column(Order = 2)]
        public string Leiras { get; set; }
        [Required]
        [Column(Order = 3)]
        public string Korosztaly { get; set; }


        [ForeignKey("Sport"), Column(Order = 4)]
        public int sportId { get; set; }

        
        public virtual Sport Sport { get; set; }


        [ForeignKey("User"), Column(Order =5)]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        [Column(Order = 6)]
        [Display(Name = "Hirdetés Címe")]
        public string Nev { get; set; }

        [Column(Order = 7)]
        public byte Lathato { get; set; } = 1;







    }
}