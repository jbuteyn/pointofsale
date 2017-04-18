using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class MakeSelections
    {
        public static void ChooseItems()
        {
            Console.WriteLine("Here's what we've got today:");
            ProductArray one = new ProductArray();
            one.PrintMenu(one.ReturnArray());
            int timesrun = 0;
            bool run = true;
            while (run == true)
            {
                timesrun++;
                Console.WriteLine("Choose the number to select an item!");
                int chosenItem = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantity? (1-5)");
                int chosenQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine(chosenItem + " " + chosenQuantity);
              //  Console.WriteLine("Total equals " + ((one.ReturnArray()[chosenItem-1].price) *chosenQuantity));
                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Make another selection? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Let's get you checked out.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}