using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert_hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allatok = new Dictionary<string, int>();
            allatok.Add("Elefánt",3);
            allatok.Add("Oroszlán",4);
            allatok.Add("Tigris",6);
            allatok.Add("Zebre",31);
            allatok.Add("Tita",2);
            foreach (var kuka in allatok)
            {
                Console.WriteLine(kuka.Key + "-" + kuka.Value);
            }
            Console.WriteLine("Állat: (Buta vagyok és nem tudom hogy kéne kérni felhasználóbarátan)");
            
            string ize = Console.ReadLine();
            Console.WriteLine("Száma/uk");
            int jaa = int.Parse(Console.ReadLine());
            if (allatok.ContainsKey(ize))
            {
                allatok[ize]+=jaa;
            }
            else
            {
                allatok.Add(ize,1);
            }
            /*foreach (var uwu in allatok)
            {
                if (ize == uwu.Key)
                {
                    allatok.Add(uwu.Key, uwu.Value+1);
                    
                }
                else
                {
                    allatok.Add(ize, uwu.Value+1);
                }

            }*/
            foreach(var ehe in allatok)
            {
                Console.WriteLine(ehe.Key +"-" + ehe.Value);
            }

        Console.ReadKey();
        }
    }
}
