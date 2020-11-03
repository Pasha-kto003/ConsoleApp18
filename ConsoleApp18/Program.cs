using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp18.cat12.Cat;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                cat c = new cat("Vladik", new DateTime(2010, 05, 25));
                c.MakeNoise();
                Console.WriteLine($"Кошке по имени {c.Name} уже {c.GetAge()} лет");
                c.HungryStatus = 150;
                Console.ReadLine();

            }

        }

    }
}
    

