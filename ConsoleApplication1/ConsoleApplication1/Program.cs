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
            string reverseStr = "I am a potato";
            reverseStr = Yodaizer(reverseStr);
            Console.WriteLine(reverseStr);

            //TextStats

            //isPrime
            for (int j = 0; j <= 25; j++)
            {
                isPrime(j);
            }
            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine(number);
            }
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

        //static int TextStats(string input)
        //{
        //    int consonants = 0, characters = 0, vowels = 0, special = 0, words = 0;

        //    string splitUp = input;

        //    for (int i = 0; i <= splitUp.Length; i++)
        //    {
        //        if (splitUp[i] == 'a' || splitUp[i] == 'e' || splitUp[i] == 'i' || splitUp[i] == 'o'
        //            || splitUp[i] == 'u' || splitUp[i] == 'A' || splitUp[i] == 'E' ||
        //            splitUp[i] == 'I' || splitUp[i] == 'O' || splitUp[i] == 'U')
        //        {
        //            vowels += 1;
        //            characters += 1;
        //        }
        //        else if (splitUp[i] == ' ' || splitUp[i] == '.' || splitUp[i] == '!' ||
        //            splitUp[i] == '?')
        //        {
        //            special = special + 1;
        //            characters += 1;
        //            if (splitUp[i] = ' ')
        //            {
        //                words += 1;
        //            }
        //        }
        //        else
        //        {
        //            consonants = splitUp.Length - speical - vowels;
        //            characters += 1;
        //        }
        //        words = words + 1;
        //        Console.WriteLine(characters, consonants, special, vowels, words);
        //    }
        //}

        static void isPrime(int number)
        {
            int divisor = 0;
            for (int i = 2; i <= number; i++)
                if (number % i == 0)
                    divisor++;

            if (number != 1 && divisor == 1)
                Console.WriteLine(number + " is a prime number");
            else
                Console.WriteLine(number);
        }
    }
}
