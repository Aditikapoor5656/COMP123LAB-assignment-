using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123LAB_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Aditi = new Person(name: "Aditi Kapoor", age: 19);

            Aditi.SaysHi();

            Console.ReadLine();
        }
    }
}
