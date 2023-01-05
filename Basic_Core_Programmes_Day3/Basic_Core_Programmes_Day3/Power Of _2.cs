using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    class Power_Of_2 
    {
        public static void PowerOfTwo() //2^1,2^2,2^3---2^i
        {
            Console.WriteLine("Enter a Number");//3
            int Number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("PowerOf 2 of Two is :" + Math.Pow(2, i));
            }
        }
    }
}
