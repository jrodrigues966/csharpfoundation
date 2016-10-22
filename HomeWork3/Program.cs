using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program calculates factorial of an integer n given by the user

            //Get user input
            Console.Write("Please enter a number: ");
            string Value = Console.ReadLine();

            //Convert user input to integer
            int input = int.Parse(Value);

            //Initialize variables such that it give the factorial of 0 or 1 to be equal to 1
            int factorial = 1;
            int k = input;

            //Find factorial when user input is strictly greater than 1 and otherwise
            if (k > 1)
            {
                do
                {
                    factorial = factorial * k;
                    k--;
                } while (k > 1);
                Console.WriteLine("The factorial of {0} is {1}", input, factorial);
            }
            else
            {
                Console.WriteLine("The factorial of {0} is 1", input);
            }
        }
    }
}
