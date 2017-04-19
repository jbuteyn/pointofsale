using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Validator
    {
        public static bool DisplayMenu()
        {
            Console.WriteLine("Display menu? (Y / N)");
            string userChoice = (Console.ReadLine().ToLower());

            { 
                if (userChoice == "y")
                {
                    return true;
                }
                else if (userChoice == "n")
                {
                    Console.WriteLine("Goodbye");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return Validator.DisplayMenu();
                }
            }

        }
        public static bool ValidateChoice(int chosenItem)
        {
            
            if (chosenItem > 0 && chosenItem <= 10)
                {
                return true;
                }
            else
                {
                    Console.WriteLine("Invalid selection.");
                return false;
                }
        }
        public static void PaymentMethod(int paymentChoice, decimal grandTotal)
        {
            if (paymentChoice == 1)
            {
                Cash one = new Cash();
                one.Checkout(grandTotal);
            }
            else if (paymentChoice == 2)
            {
                CreditCard one = new CreditCard();
                one.Checkout(grandTotal);
            }
            else if (paymentChoice == 3)
            {
                Check one = new Check();
                one.Checkout(grandTotal);
            }
            else
            {
                Console.WriteLine("That is not a valid payment method.");
            }
        }
    }
}