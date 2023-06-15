using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace _20221121_Pilota
{
    internal class Program
    {
        class Versenyzok
        {
            public string nev { get; set; }
            public DateTime szulev { get; set; }
            public string nemzet { get; set; }
            public string rajtszam { get; set; }

            public Versenyzok(string egysor)
            {
                string[] db = egysor.Split(';');
                nev = db[0];
                szulev = DateTime.Parse(db[1]);
                nemzet = db[2];
                rajtszam = db[3];
                

            }

        }

        static void Main(string[] args)
        {

            var sr = new StreamReader("pilotak.csv", Encoding.UTF8);
            
            List<Versenyzok> lista = new List<Versenyzok>();

            string elsosor = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Versenyzok sor = new Versenyzok(sr.ReadLine());
                lista.Add(sor);
            }
            sr.Close();

            Console.WriteLine(lista.Count);

            foreach (var item in lista)
            {
                
            }
            Console.WriteLine("Itt a vége");
            Console.ReadKey();
        }
    }
}
