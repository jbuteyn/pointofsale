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
        double totalPrice = 0;
        double finalPrice;
        double taxRate = .06;
        
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
        public void addPrice(double price)
        {

            totalPrice = totalPrice + price;

        }
        public double returnTotal()
        {


            return totalPrice;

        }
        public double calcTax()
        {
            finalPrice = (taxRate * totalPrice) + totalPrice;

            return finalPrice;
        }
    }

}
