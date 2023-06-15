using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221024_tetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> a = new List<int>(5) { 5, 6, 3, 2, 1 };
            List<int> b = new List<int>(5) { 6, 2, 7, 8, 9 };
            List<int> c = new List<int>();
            int j;
            for (int i = 0; i < a.Count - 1; i++)
            {
                j = 0;
                while (j < b.Count && b[j] != a[i])
                {
                    j++;
                }
                if (j < b.Count)
                {
                    c.Add(a[i]);
                }
            }
            foreach (var item in c)
            {
                Console.Write(item + " ");
            }*/
            List<int> a = new List<int>(5) { 5, 6, 3, 2, 1 };
            List<int> b = new List<int>(5) { 6, 2, 7, 8, 9 };
            List<int> c = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                c.Add(a[i]);
            }
            
            for (int j = 0; j < b.Count; j++)
            {
                int i = 0;
                    while (i<a.Count && b[j] != a[i] )
                    {
                        i++;
                    }
                if (i>=a.Count)
                {
                    c.Add(b[j]);
                }
                
            }
            foreach (var item in c)
            {
                Console.WriteLine(item + " ");
            }

                Console.ReadKey();
        }
    }
}
