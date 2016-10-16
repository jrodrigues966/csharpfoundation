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
            float SecInMin, SecInDay, SecInHour;
            float NumOfDays, NumOfHours, NumOfMin, NumOfSec;

            //Get user input   
            Console.Write("Please enter the number of seconds: ");
            string sec = Console.ReadLine();
            float x = float.Parse(sec);

            //Initialize number of seconds in a minute
            SecInMin = 60;

            //Initialize number of seconds in an hour
            SecInHour = SecInMin * SecInMin;

            //Initialize number of seconds in a day
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
