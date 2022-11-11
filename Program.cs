using System;------
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesi broj: ");
            int number = Convert.ToInt32(Console.ReadLine());
            

             bool includesInteger()
            {
                while (number > 0)
                {
                    if (number % 10 == 3) return true;
                    number /= 10;
                }
                return false;
            }

            if (includesInteger())
                Console.WriteLine("Ima broj 3");
            else
                Console.WriteLine("Nema broj 3");

            Console.ReadKey();

        }
    }
}
