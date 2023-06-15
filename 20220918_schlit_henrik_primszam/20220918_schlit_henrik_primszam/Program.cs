using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220918_schlit_henrik_primszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot, hogy megvizsgáljam hogy prím vagy sem");

            string aha = Console.ReadLine();
            int a = Convert.ToInt32(aha);

            for (int i = 1; i <= a;)
            {
                
                if (a % a == 0 && a % 1 == 0)
                {
                    if (a % 2 == 0 && a != 2)
                    {
                        Console.WriteLine("Nem prim");
                    }
                    else
                    {
                        Console.WriteLine("Prim");
                    }
                }
                

            }
            Console.ReadKey();

        }
    }
}
