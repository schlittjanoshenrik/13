using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace _20221022_schlitt_henrik_karacsonyihuzas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] huz ={5, 8, 7, 10, 3, 1, 2, 0, 4, 9 };
            Console.WriteLine($" A 7. tanuló a {huz[6]}. tanulónak adott ajándékot.");
            Console.WriteLine($"Az 5 tanulot a/az {huz.GetValue(4)} húzzta") ;
            //Feladat 3:passz
            string[] nev = { "András", "Béla", "Cecília", "Dóra", "Elemér", "Fanni", "Glória", "Hedvig", "Ilona", "József", "Katalin"};
            int igen=int.Parse(Console.ReadLine());
            //it elvagyok vérezve :/
            
            

            Console.ReadKey();
        }
    }
}
