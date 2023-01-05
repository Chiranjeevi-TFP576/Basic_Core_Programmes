using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    internal class Swap_Two_Numbers
    {
        public static void SwapNumbers()
        {
            int a, b, c;
            Console.WriteLine("Enter the Numbers a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Numbers for b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore Swaping a = {0} and b ={1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("\nAfter Swaping a={0} and b={1}", a, b);
            Console.ReadLine();
        }
    }
}
