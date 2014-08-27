using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop for FizzBuzz 0 => 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            //Loop for FizzBuzz 92 => 79
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            //Yodaizer
            string reverseStr = "I am Yoda";
            reverseStr = Yodaizer(reverseStr);
            Console.WriteLine(reverseStr);

            //TextStats
            TextStats("Here is a three sentence sentence. I like writing sentences. They are great!");

            //IsPrime
            for (int j = 0; j <= 25; j++)
            {
                IsPrime(j);
            }

            //DashInsert
            DashInsert(8675309);

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
            //Not divisible by 3 or 5
            else if (number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine(number);
            }
            //Divisible by 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
        }

        static string Yodaizer(string text)
        {
            string[] split_text = text.Split(' ');
            Array.Reverse(split_text);
            return string.Join(" ", split_text);

        }

        static void TextStats(string input)
        {
            int consonants = 0, vowels = 0, special = 0, words = 0;
            int characters = input.Length;

            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c.ToString(), 0))
                {
                    special++;
                }
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowels++;
                }
                if (c == ' ')
                {
                    words++;
                }
            }
            words = words + 1;
            consonants = characters - special - vowels;

            Console.WriteLine("Characters: " + characters + "\n Consonants: " + consonants + "\n Special: " + special + "\n Vowels: " 
                + vowels + "\n Words: " + words);
        }

        //Increases divisor up to the value of the #, checking if they are divisors for 'number'
        static void IsPrime(int number)
        {
            //Check to see if a # is divisible by another
            int divisor = 0;
            //Can start at 2, since 1 is prime
            for (int i = 2; i <= number; i++)
                if (number % i == 0)
                    //Increase divisor to see if # is divisible
                    divisor++;

            //Prime check - If divisor > 1, it's not prime
            if (number != 1 && divisor == 1)
                Console.WriteLine(number + " is a prime number");
            else
                Console.WriteLine(number);
        }

        static void DashInsert(int number)
        {
            string f = number.ToString();
            //Will stop once it gets to the end of the string
            for (int i = 0; i < f.Length; i++)
            {
                Convert.ToInt32(f[i]);
                Console.Write(f[i]);
                //Checks for 2 consecutive odd #s
                if ((f[i] % 2 != 0) && (f[i + 1] % 2 != 0))
                {
                    Console.Write("-");
                }
            }
        }
    }
}
