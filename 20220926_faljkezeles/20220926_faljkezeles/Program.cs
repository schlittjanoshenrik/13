using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220926_faljkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Koko();
            //Koko1();
            //Koko2();
            Koko3();
            Console.ReadKey();
        }
        static void Koko()
        {
            Console.WriteLine("Adjad meg a súly(kg) és a magassag(m^2)");
            double suly = double.Parse(Console.ReadLine());

            double magas = double.Parse(Console.ReadLine());
            double BMI = suly / Math.Pow(magas, 2);
            switch (BMI)
            {
                case double bmi when (bmi >= 0 && bmi < 16):
                    Console.WriteLine("Súlyos soványság");
                    break;
                case double bmi when (bmi < 17):
                    Console.WriteLine("Mérsékelten");
                    break;
                case double bmi when (bmi < 18.5):
                    Console.WriteLine("Enyhe soványság");
                    break;
                case double bmi when (bmi < 25):
                    Console.WriteLine("Normal");
                    break;
                case double bmi when (bmi < 30):
                    Console.WriteLine("Túlsúly");
                    break;
                default:
                case double bmi when (bmi <= 30):
                    Console.WriteLine("Elhízás");
                    break;
                    break;
            }
        }
        static void Koko1()
        {
            Console.WriteLine("Add meg az életkort");
            int eletkor = int.Parse(Console.ReadLine());
            switch (eletkor)
            {
                case int kor when (kor >= 0 && kor < 7):
                    Console.WriteLine("Gyerek");
                    break;
                case int kor when (kor < 19):
                    Console.WriteLine("Iskolás");
                    break;
                case int kor when (kor < 65):
                    Console.WriteLine("Felnőt");
                    break;
                case int kor when (kor < 120):
                    Console.WriteLine("Nyugdíjas");
                    break;

                default:
                    Console.WriteLine("Meg van degelve");
                    break;
            }
        }
        static void Koko2()
        {
            List<int> list = new List<int>(4);
            list.Add(1);
            list.Add(5);
            list.Add(7);
            list.Add(1);

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.Add(8);
            Console.WriteLine(list.Capacity);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //törlés a listábol indexből
            //list.RemoveAt(1);
            //Vissza rakja a kapacitást
            //list.TrimExcess();
            Console.WriteLine("előtt " + list[0]);
            list.Sort();
            Console.WriteLine("után " + list[0]);
           
        }
        static void Koko3()
        {
            Dictionary<string, string> szotar = new Dictionary<string, string>();
            //var szotar = new Dictionary<string, string>();
            szotar.Add("csicska","Te(Kivéve ha Ádám vagyol)");
            szotar.Add("Alfa","Ádam");
            szotar.Add("Hetero","Fúj");
            szotar.Add("Pingal","ÉÉÉÉÉÉÉ");
            Console.WriteLine($"A szótár {szotar.Count} elemű");
            foreach (var szo in szotar)
            {
                Console.WriteLine(szo.Key + "-" + szo.Value);
            }
            

            

        }
    }
}
