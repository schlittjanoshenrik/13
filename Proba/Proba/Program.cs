using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string proba = "abc";
            int tesztszam = Convert.ToInt32(proba);*/

            try
            {
                string sz = "gugi2";
                int conver=Convert.ToInt32(sz);
                Console.WriteLine(conver);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Csicska vagy: {e.Message}");
                
            }
            finally
            {
                Console.WriteLine($"Nyomj meg egy gombot te gyász");
            }

            Console.WriteLine("Páros köl");

            

            try
            {
                var be =Console.ReadLine();
                int szam = Convert.ToInt32(be);
                if ((szam%2)!=0)
                {
                    throw new Exception("Hát ez nem páros");
                }
                Console.WriteLine($"Páros:{szam}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Csicska vagy: {e.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba van:{ex.Message}");
                

            }
            Console.WriteLine("Kérek egy évszamot");
            string evszam = Console.ReadLine();
            int ev;
            int.TryParse(evszam, out ev);
            Console.WriteLine($"Az évszam: {ev}");

            try
            {
                var sr = new StreamReader("ige0n.txt", Encoding.UTF8);
                var list = new List<string>();
                while (!sr.EndOfStream)
                {
                    list.Add();
                }
            }
            catch (FileNotFoundException)
            {

                var list= new List<string>();
            }
            
           
            Console.ReadKey();
        }
    }
}
