using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220912_1
{
    class Car
    {
        public string tipus;
        public int ev = 2022;
        public string szin;
        public void SzinKiir()
        {
            Console.WriteLine($"Az autó: {szin}");
        }
        //konstruktor
        public Car(string autoTipus)
        {
            tipus = autoTipus;
        }
        public Car(string autoTipus, string autoSzin)
        {
            tipus = autoTipus;
            szin = autoSzin;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Car a1 = new Car("Ford Fiesta");
            var a2 = new Car("Opel Corsa");
            var a3 = new Car("Mercedes Igen", "Lila");
            //a1.tipus = "Ford Fiesta";
            a1.ev = 2006;
            a1.szin = "szürke";
            Console.WriteLine(a1.tipus);
            Console.WriteLine(a2.ev);
            a1.SzinKiir();
            Console.WriteLine(a3.szin + "-" + a3.tipus + "-" + a3.ev);
            a3.SzinKiir();


            Console.ReadKey();
        }
    }
}
