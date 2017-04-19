using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Check
    {
        public void Checkout(decimal grandTotal)
        {
            Console.WriteLine("Amount tendered");
            decimal checkAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter check number");
            decimal checknum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Payment Approved");
        }
    }
}
