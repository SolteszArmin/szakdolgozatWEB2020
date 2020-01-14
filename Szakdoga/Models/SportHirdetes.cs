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
        public int Id { get; set; }
        [Key]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public Sport Sport { get; set; }
        public int SportoloLetszam { get; set; }
        public string Leiras { get; set; }
        public int SportId { get; set; }
        public string Korosztaly { get; set; }



    }
}