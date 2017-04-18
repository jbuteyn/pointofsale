using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale
{
    class Validator
    {
        public static void DisplayMenu()
        {
            string userChoice = (Console.ReadLine().ToLower());
            if (userChoice == "y")
            {
                MakeSelections.ChooseItems();
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }
        }
    }

}