using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _20221121_Jes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = new DateTime(2022, 10, 14, 8, 15, 24, 36);
            Console.WriteLine(moment);
            int year = moment.Year;
            Console.WriteLine($"Év: {year}");
            int month = moment.Month;
            Console.WriteLine($"Hónap: {month}");
            int day = moment.Day;
            Console.WriteLine($"Nap: {day}");
            int hour = moment.Hour;
            Console.WriteLine($"Óra: {hour}");
            int minute = moment.Minute;
            Console.WriteLine($"Perc: {minute}");
            int second = moment.Second;
            Console.WriteLine($"Másodperc: {second}");
            int microsecond = moment.Millisecond;
            Console.WriteLine($"{microsecond}");


            var most = DateTime.Now;
            Console.WriteLine(most);
            int szulev = 2003;
            int eletkor = most.Year - szulev;
            Console.WriteLine(eletkor);
            string datumm = "2003-10-25";
            DateTime datum=DateTime.Parse(datumm);
            int ev = datum.Year;
            Console.WriteLine(ev);


            Console.ReadKey();
        }
    }
}
