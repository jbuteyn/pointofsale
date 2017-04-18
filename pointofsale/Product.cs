using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Product
    {
        public decimal price;
        public string name;


        public Product(decimal price, string name)
        {
            this.price = price;
            this.name = name;

        }
    }
}
