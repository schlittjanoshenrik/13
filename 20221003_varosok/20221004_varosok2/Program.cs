using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace _20221004_varosok2
{ 
        class Varos
        {
        public int hely { get; set; }
        public string varos { get; set; }
        public string orszag { get; set; }
        public int nep { get; set; }

        public Varos(string sor)
        {
            string[] db=sor.Split(';');
            hely = int.Parse(db[0]);
            varos = db[1];
            orszag = db[2];
            nep = int.Parse(db[3]);
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            var list = new List<Varos>();
            var sr =new StreamReader("varosok.txt");
            string es = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Varos sor = new Varos(sr.ReadLine());
                list.Add(sor);
            }
            sr.Close();
            foreach (var item in list)
            {
                Console.WriteLine(item.varos);
            }

            Console.WriteLine("Senki n em szereti a plesót");
            Console.ReadKey();
        }
    }
}
