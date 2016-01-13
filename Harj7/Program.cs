using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Anna Vuosi");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("On Karkausvuosi");
            }

            else
                Console.WriteLine("Ei ole karkausvuosi");
                    
                
        }
    }
}
