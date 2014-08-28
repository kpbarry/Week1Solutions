using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilding("aeioubcdef");
            Console.ReadKey();
        }

        static void StringBuilding(string input)
        {
            //Hold Output
            string output = "";
            string vowels = "aeiou";
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();
                //If it's a vowel, make it lowercase to compare with "aeiou"
                if (vowels.Contains(letter.ToLower()))
                {
                    //Add capital vowel if found
                    output += letter.ToString().ToUpper();
                }
                else
                {
                    //No vowels, lower case consonant added
                    output += letter.ToString().ToLower();
                }
            }
            Console.WriteLine(output);
        }
    }
}