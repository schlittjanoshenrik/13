using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace _20220912_2
{
    class Tanulo
    {
        private string name;
        //Java
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName() 
        { 
            return name; 
        }
    }
    class Dolgozo 
    {
        private string name; //field
        public string Name //property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Tanar
    {
        public  string Name { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Tanulo();
            t1.setName("Ahan");
            Console.WriteLine(t1.getName());

            var d1 = new Dolgozo();
            d1.Name = "Csicska";
            Console.WriteLine(d1.Name);

            var tan1= new Tanar();
            tan1.Name = "Balint";
            Console.WriteLine(tan1.Name );
            Console.ReadKey();
        }
    }
}
