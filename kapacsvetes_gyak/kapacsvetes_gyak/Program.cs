using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kapacsvetes_gyak
{
    internal class Program
    {
        class Sportolok
        {
            public int helyezes {get;set;} 
            public double eredmeny {get;set;} 
            public string nev {get;set;} 
            public string kod {get;set;} 
            public string datum {get;set;}

            public Sportolok(string sor)
            {
                string[] db = sor.Split(';');
                helyezes = int.Parse(db[0]);
                eredmeny = double.Parse(db[1]);
                nev = db[2];
                kod = db[3];
                datum = db[4];

            }
        }
        static void Main(string[] args)
        {
            var lista= new List<Sportolok>();
            var sr = new StreamReader("kalapacsvetes.txt", Encoding.UTF8);
            string elso= sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Sportolok sor = new Sportolok(sr.ReadLine());
                lista.Add(sor);
            }
            sr.Close();
            
            Console.WriteLine($"4. feladat: Ennyi dobás volt {lista.Count()}");
            var f5 = lista.Where(x => x.kod == "HUN").Select(x=>x.eredmeny).Average();
            Console.WriteLine(f5);
            Console.WriteLine("Adjon be egy évszmát");
            string be = Console.ReadLine();
            var f6 = lista.Where(x => x.datum == be);
            Console.WriteLine(f6.Count());
            foreach (var item in f6)
            {
                Console.WriteLine($"dobás: {item.nev}");
            }
            Console.WriteLine("UwU");
            Console.ReadKey();
        }
    }
}
