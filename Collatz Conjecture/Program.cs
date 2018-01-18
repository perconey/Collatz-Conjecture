using System;
using System.IO;
using System.Numerics;

namespace Collatz_Conjecture
{
    class Program
    { 
        public static BigInteger Ask()
        {
            Console.WriteLine("Enter number:");
            if (BigInteger.TryParse(Console.ReadLine(), out BigInteger num)) {}
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

                if (Int32.TryParse(Console.ReadLine(), out int choice)) { }
                else
                {
                    Console.WriteLine("Bad number provided");
                }
                switch (choice)
                {
                    case 1:
                        StreamWriter writetext = new StreamWriter("output.txt");
                        int op = 0;
                        BigInteger num = Ask();
                        while (!num.IsOne)
                        {
                            Console.WriteLine(op + ": " + num.ToString("R"));
                            if (num % 2 == 0)
                            {
                                num = num / 2;
                            }
                            else
                            {
                                num = 3 * num + 1;
                            }
                            op++;
                            writetext.WriteLine(op + ": " + num.ToString("R"));
                        }
                        Console.WriteLine(op + ": 1");
                        Console.WriteLine($"Operations performed: {op}");
                        writetext.Close();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
//41892739812790846718792364871235678162736476762763746736476467368746128734687162537684581756156536512786458176253876178263547865