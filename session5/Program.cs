using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5
{
    class Program
    {
        static void Main(string[] args)
        {
            //float sum = 0.0f;
            //float avg;
            //for (int x = 1; x <= 10; x++)
            //{
            //    Console.Write("Enter a number from {0} to 10: ", x);
            //    string input = Console.ReadLine();

            //    float i = float.Parse(input);

            //    sum = sum + i;               
            //}
            //avg = sum / 10;
            //Console.WriteLine("The average of the number is {0}", avg);


            int[] myarray = new int[] { 5, -2, 100, 12, 4, -5 };

            int min;
            int max;

            min = myarray[0];
            max = myarray[0];
            foreach (int i in myarray)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
                Console.WriteLine("The min is {0}", min);
                Console.WriteLine("The max is {0}", max);
            }
        }
    }
}
