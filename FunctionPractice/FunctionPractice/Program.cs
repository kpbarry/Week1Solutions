using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Greet("Kevin");
            int myAgeDoubled = DoubleIt(23);
            Console.WriteLine(myAgeDoubled);
            Console.WriteLine(Multiply(myAgeDoubled, 4));
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Multiply(i, 3));
            }
            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int DoubleIt(int num)
        {
            return num * 2;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
