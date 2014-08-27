using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop for fizzbuzz 1 => 35
            for (int i = 1; i <= 35; i++)
            {
                FizzBuzz(i);
            }
            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            //This condition must be checked first to ensure a # is divisible by both #s
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //If divisible by 3 print Buzz
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //Divisible by 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //Not divisible by 3 or 5
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
