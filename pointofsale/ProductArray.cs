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
        

        public ProductArray()
        {
            Product[] prodArray = new Product[10];
            


        }
        public Product[] returnArray()
        {
            prodArray[0] = new Product(3.50, "Regular Coffee");
            prodArray[1] = new Product(4.25, "Latte");
            prodArray[2] = new Product(4.00, "Espresso");
            prodArray[3] = new Product(3.25, "Cold Brew");
            prodArray[4] = new Product(1.75, "Bagel");
            prodArray[5] = new Product(2.25, "Muffin");
            prodArray[6] = new Product(3.00, "Scone");
            prodArray[7] = new Product(0.00, "Water");
            prodArray[8] = new Product(1.00, "Tea");
            prodArray[9] = new Product(12.00, "Logo Mug");
            return prodArray;
        }
    }
}
