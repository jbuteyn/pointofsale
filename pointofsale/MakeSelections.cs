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
            Console.WriteLine("Today's Menu:");
            ProductArray one = new ProductArray();
            one.PrintMenu(one.ReturnArray());
            Product[] oneA = one.ReturnArray();
            Receipt test = new Receipt();
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter customer selection:");
                int chosenItem;
                bool valid = int.TryParse(Console.ReadLine(), out chosenItem);
                if (valid == true && chosenItem > 0 && chosenItem <= 10)
                {
                    Console.WriteLine("Quantity?");
                    int chosenQuantity;
                    try
                    {
                       chosenQuantity = int.Parse(Console.ReadLine());

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid input");
                        chosenQuantity = 0;
                    }
                    string chosenName = oneA[chosenItem - 1].name;
                    decimal chosenPrice = (oneA[chosenItem - 1].price) * chosenQuantity;
                    string finalChoice = (chosenName + " x" + chosenQuantity + " $" + chosenPrice);
                    test.addToReceipt(finalChoice);
                    test.addPrice(chosenPrice);
                    run = Continue();
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                   // run = Continue();
                    //break;
                }
            }
            test.printReceipt();
            Console.WriteLine("subtotal is "+test.returnTotal());
            decimal grandTotal = test.calcTax();
            Console.WriteLine("Total w/tax " + grandTotal);
            Console.WriteLine("Enter payment method:\n1 for Cash \n2 for Credit \n3 for Check)");
            int paymentChoice = int.Parse(Console.ReadLine());
            Validator.PaymentMethod(paymentChoice, grandTotal);
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Make another selection? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Customer Receipt:");
                run = false;
                
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                run = Continue();
            }

            return run;
        }
    }
}