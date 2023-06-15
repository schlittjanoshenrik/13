using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221108_gyakorlas
{
    class Ber
    {
        public string nev { get; set; }
        public string neme { get; set; }
        public string reszleg { get; set; }

        public string belepes { get; set; }
        public int ber { get; set; }

        public Ber(string sor)
        {
            string[] reszek = sor.Split(';');
            nev = reszek[0];
            neme = reszek[1];
            reszleg = reszek[2];
            belepes = reszek[3];
            ber = int.Parse(reszek[4]);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Ber> lista = new List<Ber>();
                StreamReader sr = new StreamReader("berek2020.txt");
                string elsosor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Ber sor = new Ber(sr.ReadLine());
                    lista.Add(sor);
                }
                sr.Close();
                Console.WriteLine($"3.feladat : Dolgozok száa;{lista.Count} fő");
                double osszeg = 0;
                foreach (var item in lista)
                {
                    osszeg += item.ber;
                }
                double atlag = osszeg / lista.Count / 1000;
                Console.WriteLine("5.feladat : kérem egy részleg nevét :");

                bool vanreszleg = false;
                int maxber = 0;
                int maxindex = 0;
                string reszlegnev = Console.ReadLine();
                for (int i = 0; i < lista.Count; i++)
                {
                    vanreszleg = true;
                    if (lista[i].ber == maxber)
                    {
                        maxber = lista[i].ber;
                        maxindex = i;
                    }
                }
                if (vanreszleg)
                {
                    Console.WriteLine($"Feladat 6: {lista[maxindex].nev} {maxber}");
                }
                else
                {
                    Console.WriteLine("részleg nem létezik");
                }

            //7feladat

                Dictionary<string, int> dict = new Dictionary<string, int>();
                foreach (var item in lista)
                {
                    if (dict.ContainsKey(item.reszleg))
                    {
                        dict[item.reszleg]++;
                    }
                    else
                    {
                        dict.Add(item.reszleg, 1);
                            
                    }
                }
                foreach (var item in dict)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value} fő");
                }


                Console.ReadKey();
            }
        }
    }
}
