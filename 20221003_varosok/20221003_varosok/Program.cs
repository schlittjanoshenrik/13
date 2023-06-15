using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace _20221003_varosok
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            //olvasasSR();
            //irasSrR();
            //olvasasRAL();
            //irasSRnelkul();
            feladat();
            Console.ReadKey();
        }
        static void olvasasSR()
        {
            var sr = new StreamReader("varosok.txt");
            var list = new List<string[]>();
            string elsosor = sr.ReadLine();
            string sor;
            string[] db;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                db = sor.Split(';');
                list.Add(db);

            }

            foreach (var item in list)
            {
                Console.WriteLine(item[0] + ' ' + item[1] + ' ' + item[2] + ' ' + item[3]);
            }
            sr.Close();
        }
        static void irasSrR()
        {
            var sr = new StreamReader("varosok.txt");
            var list = new List<string[]>();
            string elsosor = sr.ReadLine();
            string sor;
            string[] db;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                db = sor.Split(';');
                list.Add(db);

            }
            StreamWriter sw = new StreamWriter("kiir.txt" /*, append:true*/);
            sw.WriteLine(elsosor);
            foreach (var item in list)
            {
                sw.WriteLine(item[0] + ';' + item[1] + ';' + item[2] + ';' + item[3]);
            }
            /*sw.Flush();
            sw.Close();*/

        }
        static void olvasasRAL()
        {
            string[] sorok = File.ReadAllLines("varosok.txt");
            var list = new List<string[]>();
            foreach (var item in sorok)
            {
                string[] reszek = item.Split(';');
                list.Add(reszek);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item[0]+" "+ item[1] + " " + item[2] + " " + item[3]);
            }
        }
        static void irasSRnelkul()
        {
            string[] sorok = File.ReadAllLines("varosok.txt");
            File.WriteAllLines("kiir.txt",sorok);
            File.AppendAllLines("kiir.txt",sorok);
        }
        static void feladat()
        {

        }
    }
}
