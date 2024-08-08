using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Calculator
{
    class Calculations : Utility
    {
        public void Simplification()
        {
            //Getting started with First number as input
            int answer = IntegerInput();

            while (true)
            {
                //Getting Operator Input
                string choice = StringInput();

                if (choice == "=")
                {
                    Console.WriteLine("\n" + answer + "\n" + "\n============================================= \n");
                    Simplification();
                }
                else
                {
                    //Getting next number as input
                    int number = IntegerInput();

                    if (choice == "+")
                    {
                        answer += number;
                    }
                    else if (choice == "-")
                    {
                        answer -= number;
                    }
                    else if (choice == "*")
                    {
                        answer *= number;
                    }
                    else if (choice == "/")
                    {
                        if(number == 0)
                        {
                            Console.WriteLine("\nInfinity\n\n============================================= \n");
                            Simplification();
                        }
                        answer /= number;
                    }
                }
            }
        }
    }
}
