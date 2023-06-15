using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220927_fáljkezelés_könyvtar
{
    internal class Program
    {
        class UwU
        {

        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("nobel.txt");
            string sor = sr.ReadLine();
            Console.WriteLine(sor);


            Console.ReadKey();
        }
    }
}
