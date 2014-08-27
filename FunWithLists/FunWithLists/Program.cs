using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a new list of strings for a menu
            List<string> myMenu = new List<string>(){"Pizza", "Tacos", "Hummus", "Instant Potatoes", "Twix"};

            //Add one more menu item
            myMenu.Add("Deep Fried Oreos");

            //Remove something
            myMenu.Remove("Pizza");
            myMenu.RemoveAt(1);

            //Another easy way to print out an array
            Console.WriteLine(string.Join(", ", myMenu));

            //Loop through and print each
            for (int i = 0; i < myMenu.Count; i++)
            {
                //Set a variable equal to the current item in our list
                string item = myMenu[i];
                if (item.ToLower().Contains("twix"))
                {
                    Console.WriteLine(item.ToUpper());
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
