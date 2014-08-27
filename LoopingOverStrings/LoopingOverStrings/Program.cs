using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindALetter("a", "WhoaaaaaaAa");
            FindAWord("blargh", "I am a blargh zombie blargh");
            Console.ReadKey();
        }

        static void FindALetter(string letterToFind, string text)
        {
            int letterCount = 0;

            //Loop over the string
            for(int i = 0; i < text.Length; i++)
            {
                //Convert char to string
                string letter = text[i].ToString();
                //Set letter to lower, check if it matches letterToFind
                if (letter.ToLower().Contains(letterToFind))
                {
                    //If found, increase counter
                    letterCount++;
                }
            }
            Console.WriteLine("Found " + letterCount + " " + letterToFind + "'s" + " in " + text);
        }
        //Function to loop over words in a string
        static void FindAWord(string wordToFind, string text)
        {
            //Counter
            int wordCount = 0;
            //Split string to words
            List<string> words = text.Split(' ').ToList();
            //Loop over the string
            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                //Set letter to lower, check if it matches letterToFind
                if (word.ToLower() == wordToFind.ToLower())
                {
                    //If found, increase counter
                    wordCount++;
                }
            }
            Console.WriteLine("Found " + wordCount + " " + wordToFind + "'s" + " in " + text);
        }
    }
}