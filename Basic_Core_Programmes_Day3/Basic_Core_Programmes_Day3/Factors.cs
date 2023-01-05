using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    internal class Factors
    {
        public static void PrimeFactorial()
        {
            int num;
            Console.WriteLine("Enter any Number to check PrimeFactor ");//5,
                                                                        //12->1,2,3,4,6
                                                                        //primefactors -2,3 but 2*3 =6 so we convert itslf 2*2*3
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; num > 1; i++)//prime factor start with 2
            {
                if (num % i == 0)
                {
                    int x = 0;
                    while (num % i == 0)//5
                    {
                        num /= i;
                        x++;
                    }
                    Console.WriteLine($"{i} is prime factor \n {x} times");
                }

            }

        }
    }
}
