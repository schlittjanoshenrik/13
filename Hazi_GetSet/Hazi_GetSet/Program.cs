using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hazi_GetSet
{
    class Kuty
    {   
        public string Ehe { get; set; }
        public string fajta;
        public string minta;
        public int kor =1;//év

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {


            var kuty1=new Kuty();
            kuty1.fajta = "Huszky";
            kuty1.minta = "Albino";
            Console.WriteLine( kuty1.minta+ " " + kuty1.fajta + " " +kuty1.kor);

            var kuty2=new Kuty();
            kuty2.Ehe = "Paraszt";
            
            Console.ReadKey();
        }
    }
}
