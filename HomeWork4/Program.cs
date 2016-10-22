using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program allows the user to enter the number of factorials to display.

            //Get user input and convert to integer
            Console.Write("Please enter a number: ");
            string Value = Console.ReadLine();
            int input = int.Parse(Value);

            //Initialize a variable such that factorial of 1 or zero gives 1 
            int factorial = 1;

            //Initialize variable to increment
            int i = 0;

            //Crank the wheel
            do
            {
                i++;
                factorial = factorial * i;
                Console.WriteLine("{0}! = {1}", i, factorial);
            } while (i < input);
        }
    }
}