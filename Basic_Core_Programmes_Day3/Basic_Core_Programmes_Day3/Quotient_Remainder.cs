using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programmes_Day3
{
    public class Quotient_Remainder
    {
        public static void CheckReminderQuotent()
        {
            int dividend = 0, divisor = 0;

            Console.WriteLine("Compute the Quotient and Reminder in C#");
            Console.WriteLine("Enter the first number:");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter the Second number:");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int reminder = dividend % divisor;
            Console.WriteLine("Dividend {0} Divisor {1}", dividend, divisor);//{ 0} place holder
            Console.WriteLine("\n\n Quotient = :" + quotient);
            Console.WriteLine("\n\n Reminder = :" + reminder);

        }
    }
}
