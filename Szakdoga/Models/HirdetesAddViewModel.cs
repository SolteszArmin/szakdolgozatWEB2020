using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class HirdetesAddViewModel
    {
        public SportHirdetes sportHirdetes { get; set; }
        public List<Sport> Sport { get; set; }
        public List<string> KrosztalyLista { get; set; }

    }
}