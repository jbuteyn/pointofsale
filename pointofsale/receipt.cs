using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Receipt
    {
        List<string> userReceipt = new List<string>();
        decimal totalPrice = 0m;
        decimal finalPrice;
        decimal taxRate = .06m;
        
        public void addToReceipt(string addItem)
        {
            userReceipt.Add(addItem);

        } 
        
        public void printReceipt()
        {
            for (int i = 0; i< userReceipt.Count; i++)
			{
                Console.WriteLine(userReceipt[i]);
			}
        
        
        }
        public void addPrice(decimal price)
        {

            totalPrice = totalPrice + price;

        }
        public decimal returnTotal()
        {


            return totalPrice;

        }
        public decimal calcTax()
        {
            finalPrice = (taxRate * totalPrice) + totalPrice;

            return finalPrice;
        }
    }

}
