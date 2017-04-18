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

            Console.WriteLine("Welcome to JBM Coffee Shop! We specialize in legal addictive stimulants at cheaper prices than our competitors.");
            Console.WriteLine("Can we have a name for your order?");
            string userName = Console.ReadLine();
            Console.WriteLine("Thanks " + userName + "! Would you like to peruse our menu? (Y/N)");
            Validator.DisplayMenu();
        }
    }
}
