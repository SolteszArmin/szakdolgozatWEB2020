using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class Korosztaly
    {
        const string gyerek = "16-18";
        const string tini = "19-25";
        const string felnott = "26-40";
        const string idos = "41-60";

        public List<string> korosztalyLista = new List<string>(4)
        {
            gyerek,
            tini,
            felnott,
            idos
        };
        
    }
}