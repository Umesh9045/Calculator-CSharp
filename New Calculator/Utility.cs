using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Calculator
{
    class Utility
    {
        public int IntegerInput()
        {
            try
            {
                //Integer input
                int userInput = Convert.ToInt32(Console.ReadLine());
                return userInput;
            }
            catch
            {
                return IntegerInput();
            }
        }

        public string StringInput()
        {
            //String Input
            string? userInput = Console.ReadLine();

            if (userInput == "+" || userInput == "-" || userInput == "/" || userInput == "*" || userInput == "=")
            {
                return userInput;
            }
            else
            {
                return StringInput();
            }

        }
    }
}
