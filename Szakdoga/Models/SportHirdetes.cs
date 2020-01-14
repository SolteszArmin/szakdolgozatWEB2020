using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class SportHirdetes
    {
        public int Id { get; set; }
        public Sport Sport { get; set; }
        public int SportoloLetszam { get; set; }
        public string Leiras { get; set; }
        public int SportId { get; set; }
        public string Korosztaly { get; set; }



    }
}