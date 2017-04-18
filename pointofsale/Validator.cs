using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Validator
    {
        public static void DisplayMenu()
        {
            string userChoice = (Console.ReadLine().ToLower());
            if (userChoice == "y")
            {
                MakeSelections.ChooseItems();
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }
        }
        //public static void PaymentMethod(int paymentChoice, decimal grandTotal)
        //{
        //    if (paymentChoice == 1)
        //    {
        //        Cash.Checkout(grandTotal);
        //    }
        //    else if (paymentChoice == 2)
        //    {
        //        CreditCard.Checkout(grandTotal);
        //    }
        //    else if (paymentChoice == 3)
        //    {
        //        Check.Checkout(grandTotal);
        //    }
        //    else
        //    {
        //        Console.WriteLine("That is not a valid payment method. Please enter 1 for Cash, 2 for Credit, or 3 for Check.");
        //    }
        //}
    }
}