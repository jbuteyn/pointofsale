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
            // Product.PrintMenu;
            //This will ideally be a method run on Josh's 2-dimensional array in the Product class that will print out the name of each item
            // followed by the price of each item.
            int timesrun = 0;
            bool run = true;
            while (run == true)
            {
                timesrun++;
                Console.WriteLine("Choose the letter to select an item!");
                string chosenItem = Console.ReadLine();
                Console.WriteLine("Quantity? (1-5)");
                int chosenQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine(chosenItem + " " + chosenQuantity);
                Continue();
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
        //Product.StoreItem
        //This will be a method in the Product class that ideally will draw information from Josh's 2-D array (item name and price total
        // for the quantity of the item) and store these in a separate list or array titled chosenItems.
    }

}
