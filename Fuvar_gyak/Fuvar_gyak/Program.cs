using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Fuvar_gyak
{
    internal class Program
    {
        class Fuvar
        {
            public int azon { get; set; }
            public string indulas { get; set; }
            public int idotartam { get; set; }
            public float tavolsag { get; set; }
            public float dij { get; set; }
            public float bor { get; set; }
            public string fizmod { get; set; }
            public Fuvar(string sor)
            {
                var db = sor.Split(';');
                azon = int.Parse(db[0]);
                indulas = db[1];
                idotartam= int.Parse(db[2]);
                tavolsag = float.Parse(db[3]);
                dij = float.Parse(db[4]);
                bor = float.Parse(db[5]);
                fizmod=db[6];
            }
        }
        static void Main(string[] args)
        {
            var sr = new StreamReader("fuvar.csv"/*, Encoding.UTF8*/);
            var elso = sr.ReadLine();
            var lista= new List<Fuvar>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Fuvar(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3. feladat: {lista.Count} fuvar");
            var f4 = lista.Where(x=>x.azon == 6185).Select(x=>x.bor+x.dij);
            Console.WriteLine($"4. feladat: {f4.Count()} fuvar alatt: {f4.Sum()}$");
            var f5 = lista.GroupBy(x=>x.fizmod);
            Console.WriteLine("5. feladat:");
            foreach (var item in f5)
            {
                Console.WriteLine($"{item.Key} {item.Count()} fuvar");
            }
            var f6 = lista.Select(x => x.tavolsag*1.6).Sum();
            Console.WriteLine($"6. feladat: {f6:.##}km");
            var f7 = lista.OrderBy(x=>x.idotartam).Last();
            Console.WriteLine($"7. feladat:");
            Console.WriteLine($"        Fuvar hossza: {f7.idotartam} másodperc:");
            Console.WriteLine($"        Taxi azonosító: {f7.azon} ");
            Console.WriteLine($"        Megtett távolság: {f7.tavolsag:.#} km");
            Console.WriteLine($"        Viteldíj: {f7.dij}$");
            Console.WriteLine("Enter");
            Console.ReadKey();
        }
    }
}
