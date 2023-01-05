using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    internal class Largest_Among_3_Numbers
    {
        public static void FindLargest_3_Number()
        {
            int a, b, c;
            Console.WriteLine("Find the Largest Number Among Three Numbers");
            Console.WriteLine("\nEnter First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is grater amongz three numbers");
                }
                else
                {
                    Console.WriteLine("c is greater among three numbers");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater among three numbers");
            }
            else
            {
                Console.WriteLine("c is greater among three numbers");
            }

        }
    }
}
