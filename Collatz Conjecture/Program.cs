using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture
{
    class Program
    {
        public static Decimal Ask()
        {
            Console.WriteLine("Enter number:");
            if (Decimal.TryParse(Console.ReadLine(), out decimal num))
            {

            }
            else
            {
                Console.WriteLine("Bad number");
            }
            return num;
        }
        static void Main(string[] args)
        {
            while(true)
            {

            Console.WriteLine("What you want to do?");
            Console.WriteLine("1. Check a number for being a solution");
            Console.WriteLine("2. ");

                int choice;
                if (Int32.TryParse(Console.ReadLine(), out choice)) { }
                else
                {
                    Console.WriteLine("Bad number provided");
                }

            switch (choice)
                {
                    case 1:
                        Decimal num = Ask();
                        while(num >= 2)
                        {
                        Console.WriteLine(num);
                        if (num % 2 == 0)
                        {
                            num *= 0.5M;
                        }
                        else
                        {
                            num = 3 * num + 1;
                        }

                        }
                        break;
                }
    
            }
        }
    }
}
