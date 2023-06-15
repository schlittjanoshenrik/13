using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzeria_gyak
{
    public  class Pizzak
    {
        public string nev { get; set; }
        public int kicsi { get; set; }
        public int nagy { get; set; }

        public Pizzak(string sor)
        {
            string[] db = sor.Split(';');
            nev = db[0];
            kicsi= int.Parse(db[1]);
            nagy= int.Parse(db[2]);
        }
    }
}
