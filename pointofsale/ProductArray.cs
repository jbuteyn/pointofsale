using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class ProductArray
    {
        Product[] prodArray = new Product[10];

        public Product[] ReturnArray()
        {
            Product[] prodArray = new Product[10];
            prodArray[0] = new Product(3.50m, "Regular Coffee");
            prodArray[1] = new Product(4.25m, "Latte");
            prodArray[2] = new Product(4.00m, "Espresso");
            prodArray[3] = new Product(3.25m, "Cold Brew");
            prodArray[4] = new Product(1.75m, "Bagel");
            prodArray[5] = new Product(2.25m, "Muffin");
            prodArray[6] = new Product(3.00m, "Scone");
            prodArray[7] = new Product(0.00m, "Water");
            prodArray[8] = new Product(1.00m, "Tea");
            prodArray[9] = new Product(12.00m, "Logo Mug");

            return prodArray;
        }
        public void PrintMenu(Product[] ReturnArray)
        {
            for (int i = 0; i < prodArray.Length; i++)
            {
                Console.WriteLine("Selection " + (i + 1) + ": " + ReturnArray[i].name.PadRight(15) + "        " + ReturnArray[i].price.ToString().PadLeft(10));
            }
        }
        public decimal returnPrice(int i)
        {

            return prodArray[i].price;

        }
        public string returnName(int i)
        {

            return prodArray[i].name;

        }
    }
}
