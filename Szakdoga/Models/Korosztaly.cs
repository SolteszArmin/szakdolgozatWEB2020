using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szakdoga.Models
{
    public class Korosztaly
    {
        const string gyerek = "6-13";
        const string tini = "14-17";
        const string felnott = "18-30";
        const string idos = "31-50";

        public List<string> korosztalyLista = new List<string>(4)
        {
            gyerek,
            tini,
            felnott,
            idos
        };
        
    }
}