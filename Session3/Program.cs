using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.Write("Please enter your input: ");
            string str = Console.ReadLine();
            int x = int.Parse(str);
            int Result = (int)(5 *x*x + 6);
            Console.WriteLine("The calculated value is {0}", Result);
            Console.ReadLine();          
        }
    }
}
