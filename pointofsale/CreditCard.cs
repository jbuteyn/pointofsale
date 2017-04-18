using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class CreditCard
    {
        public void Checkout(decimal grandTotal)
        {
            Console.WriteLine("Please enter Credit Card Number");
            decimal cardNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter expiration date in 2 digit month and year");
            decimal expdate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter 3 digit CCV number");
            decimal CVV = decimal.Parse(Console.ReadLine());
            Console.WriteLine("JBM Coffee Shop will charge " + grandTotal + "to card number " + cardNumber + " expiration date " + expdate + " CVV " + CVV);
        }
    }
}
