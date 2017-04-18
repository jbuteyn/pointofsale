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
            // followed by the price of each items.
            ProductArray one = new ProductArray();
            one.PrintMenu(one.ReturnArray());
            Product[] oneA = one.ReturnArray();
            int timesrun = 0;
            bool run = true;
            receipt test = new receipt();

            while (run == true)
            {

                timesrun++;
                Console.WriteLine("Choose the number to select an item!");
                int chosenItem = int.Parse(Console.ReadLine());
                string chosenName = oneA[chosenItem].name; 
                Console.WriteLine("Quantity? (1-5)");
                int chosenQuantity = int.Parse(Console.ReadLine());
                double chosenPrice = (oneA[chosenItem].price) * chosenQuantity;
                string finalChoice = (chosenName + " " + "$"+chosenPrice);
                test.addToReceipt(finalChoice);
                test.addPrice(chosenPrice);
                run = Continue();

                
                
            }
            test.printReceipt();
            test.printTotal();
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Make another selection? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Let's get you checked out. \nHere is your receipt");
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