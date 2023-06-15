using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Runtime.InteropServices;

namespace _20220913
{
    class Tutu
    {
        public string tipus { get; set; }
        public string szin { get; set; }
        public int ev { get; set; }
        public string rendszam { get; set; }
        

        public int Ev()
        {
            int kor = 2022 - ev;
            return kor; 

        }
        public Tutu(string _rendszam)
        {
            rendszam = _rendszam;
        }
    }
    class Kor
    {
        public double sugar { get; set; }
        public double Kerulet()
        {
            double kerulet = 2 * sugar * Math.PI;
            return kerulet; 
        }
        public double Terulet()
        {
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            return terulet;
        }

        public  Kor(double _sugar)
        {
            sugar = _sugar;
        }
    }
    class Tegla
    {
        public double a { get; set; }
        public double b { get; set; }
        public double KeruletT()
        {
            double keruletT = (a+b)*2;
            return keruletT;
        }
        public double TeruletT()
        {
            double teruletT = a*b;
            return teruletT;
        }

        public Tegla(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            /*var a1 = new Tutu("TOFU-124");
            a1.ev = 2012;
            a1.szin = "GyöngyFehér";
            a1.tipus = "Mercy Csicska";
            Console.WriteLine($"A {a1.tipus}-t {a1.Ev()} eves");*/
            //Anyu();
            Anyu2();
            Console.ReadKey();

        }
        static void Anyu()
        {
            //r*r*pi, 2*r*p
            var k1 = new Kor(11);
            Console.WriteLine($"Terület:{k1.Terulet():0.##}, Kerület: {k1.Kerulet():0.##}");
            

        }
        static void Anyu2()
        {
            var t1 = new Tegla(11,52);
            Console.WriteLine($"Terület:{t1.TeruletT():0.##}, Kerület: {t1.TeruletT():0.##}");
        }
    }
}
