using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    public class Leap_Year
    {
        public void LaepYearCheck()
        {
            Console.WriteLine("Enter Year Number whether to Check Leap");
            int Year = Convert.ToInt32(Console.ReadLine());


            if (Year % 4 == 0)
            {
                Console.WriteLine(" {0} is a Leap Year:", Year);
            }
            else if (Year % 400 == 0)
            {
                Console.WriteLine(" {0} is a Leap Year:", Year);
            }
            else
            {
                Console.WriteLine(" {0} is not a Leap Year:", Year);
            }

        }
    }
}
