using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileLoopTest();
            //FlipACoin(100000);
            FlipForHeads(100);
            Console.ReadKey();
        }

        static void WhileLoopTest()
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void FlipACoin(int flips)
        {
            int countHeads = 0, countTails = 0;
            Random rng = new Random();

            for (int i = 0; i < flips; i++)
            {
                int flip = rng.Next(0, 2);
                if (flip == 0)
                {
                    countTails++;
                }
                else
                {
                    countHeads++;
                }
            }
            Console.WriteLine("# of Heads " + countHeads + "\n# of Tails " + countTails);
        }

        static void FlipForHeads(int numHeads)
        {
            //# of heads
            int headsFlipped = 0;
            //Incrementor for our loop
            int totalFlips = 0;
            Random rng = new Random();
            while (headsFlipped <= numHeads)
            {
                //Increment if heads
                if ((rng.Next(0, 2)) == 1)
                {
                    headsFlipped += 1;
                }
                totalFlips++;
            }
            Console.WriteLine("It took " + totalFlips + " flips to get " + numHeads + " heads.");
        }
    }
}
