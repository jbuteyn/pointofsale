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

            Console.WriteLine("JBM Coffee Shop Point of Sale Terminal");
            Console.WriteLine("Enter customer name");
            string userName = Console.ReadLine();
            bool run = Validator.DisplayMenu();
            while (run == true)
            {
                MakeSelections.ChooseItems();
                Console.WriteLine("End of sale.");
                run = Validator.DisplayMenu();
            }
        }

    }
}
