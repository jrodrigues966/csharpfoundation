using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the type of variable
            float SecInMin, SecInDay, SecInHour;
            float NumOfDays, NumOfHours, NumOfMin, NumOfSec;

            //Get user input   
            Console.Write("Please enter the number of seconds: ");
            string sec = Console.ReadLine();
            float x = float.Parse(sec);

            //Assign number of seconds in a minute to the variable
            SecInMin = 60;

            //Assign number of seconds in an hour to the variable
            SecInHour = SecInMin * SecInMin;

            //Assign number of seconds in a day to the variable
            SecInDay = SecInHour * 24;

            //Calculate number of days, hours, minutes and seconds from the user input
            NumOfDays = (x / SecInDay);
            NumOfHours = (x / SecInHour);
            NumOfMin = (x / SecInMin);
            NumOfSec = (NumOfMin * SecInMin);

            Console.WriteLine("The calculated conversions are {0} days, {1} hours, {2} minutes & {3} seconds.", NumOfDays, NumOfHours, NumOfMin, NumOfSec);
            Console.ReadLine();
        }
    }
}
