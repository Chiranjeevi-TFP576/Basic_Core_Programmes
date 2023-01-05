using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    internal class Harmonic__Number
    {
        public static void HarmonicSeries()//1/1+1/2=5/3=1.3
        {
            double harmonicSum = 0;
            Console.WriteLine("Enter a Number to find Harmonic:");//2
            double num = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= num; i++)
            {
                Console.Write("1/{0}+", i);//{0}  place value
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n The Sum of harmonic number is " + harmonicSum);
        }
    }
}
