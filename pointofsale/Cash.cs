using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Cash
    {
        public void Checkout(decimal grandTotal)
        {
            Console.WriteLine("Enter Amount Tendered");
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal change = (cash - grandTotal);
            Console.WriteLine("Your change is " + change);
        }
    }
}
