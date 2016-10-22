using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////find the acci value of a given character

            ////Ask the user to enter a character in front of the request
            //Console.Write("Please enter a character: ");

            ////Read and store the input from the user
            //string input = Console.ReadLine();

            ////make sure you grab the first character that they enter
            //char ch = input[0];
            //char ch1 = input[0];
            ////grab or convert the character into a number(ascii number). Going from 2 bytes to integer 4 bytes
            //int myascii = (int) ch * (int) ch;

            ////show the integer or the result on the console
            //Console.WriteLine("The ascii for {0} is {1}", input, myascii);

            //Console.Write("Enter a person's full name: ");
            //string str = Console.ReadLine();
            //str.EndsWith("Smith");

            //if (str.EndsWith("Smith"))
            //{
            //    Console.WriteLine("You found a Smith!");
            //}
            //double dblOvertimePay;
            //double dblRegularPay;
            //double dblTotalPay;

            //Console.Write("Please enter the number of hours worked: ");
            //string strHours = Console.ReadLine();
            //double dblHours = double.Parse(strHours);

            //Console.Write("Please enter your hourly wage($/hour): ");
            //string strWage = Console.ReadLine();
            //double dblWage = double.Parse(strWage);

            //if (dblHours > 40)
            //{
            //    dblOvertimePay = (dblHours - 40) * 1.5;
            //    dblRegularPay = 40 * dblWage;
            //    dblTotalPay = dblOvertimePay + dblRegularPay;

            //    Console.WriteLine()
            //}
            Console.Write("Please eneter a month number (1 to 12): ");
            string strName = Console.ReadLine();

            string month;
            int nDays = 0;

            switch (strName)
            {
                case "1":
                    month = "January";
                    nDays = 31;
                    break;

                case "2":
                    month = "February";
                    nDays = 29;
                    break;

                case "3":
                    month = "March";
                    nDays = 31;
                    break;

                default:
                    month = "unknown";
                    nDays = -1;
                    break;
            }
            Console.WriteLine("The month {0} has {1} days", month, nDays);
        }
    }
}
