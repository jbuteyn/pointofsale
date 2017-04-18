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
            Product[] oneA = one.ReturnArray();
            int timesrun = 0;
            bool run = true;
            receipt test = new receipt();

            while (run == true)
            {

                timesrun++;
                Console.WriteLine("Choose the number to select an item!");
                int chosenItem = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantity? (1-5)");
                int chosenQuantity = int.Parse(Console.ReadLine());
                
                string chosenName = oneA[chosenItem].name;
                double chosenPrice = (oneA[chosenItem].price) * chosenQuantity;
                string finalChoice = (chosenName + " " + "$" + chosenPrice);
                test.addToReceipt(finalChoice);
                test.addPrice(chosenPrice);
                run = Continue();
                //  Console.WriteLine("Total equals " + ((one.ReturnArray()[chosenItem-1].price) *chosenQuantity));

            }
            test.printReceipt();
            Console.WriteLine("subtotal is "+test.returnTotal());
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