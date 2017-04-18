using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            ProductArray one = new ProductArray();
            Product[] oneA = one.returnArray();
            Console.WriteLine(oneA[i]);

        }
    }
}
