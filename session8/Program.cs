using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session8
{
    class Stack
    {
        private int[] stack = new int[5];
        private int sp = 0;
        //Dynamically grow
        public void Push(int v)
        {
            stack[sp = sp + 1] = v;

            //Identify if texceeding the length
            if (sp == stack.Length)
            {
                //create new array with a longer length
                int n = stack.Length * 2;
                int[] newstack = new int[n];

                //copy the old into new
                stack.CopyTo(newstack, 0);

                //toss the old stack away
                stack = newstack;
            }
        }
        public int Top
        {
            get
            {
                return stack[sp - 1];
            }
        }
        public bool IsEmpty
        {
            get
            {
                return sp == 0;
            }
        }
        public int Pop()
        {
            return stack[sp = sp - 1];
        }
    }

    //Design RPN. RPN is a "user" of the Stack class. Main is a "user" of RPN class
    class RPN
    {
        //create an object of class Stack
        private Stack stack = new Stack();

        public void Process(string str)
        {
            switch (str)
            {
                case "+":
                    {
                        // do the code to add the last two numbers
                        int result = stack.Pop() + stack.Pop();
                        // and save it in the stack
                        stack.Push(result);
                        break;
                    }
                case "-":
                    {
                        // do the code to subtract the last from previous
                        int result = stack.Pop() - stack.Pop();
                        // and save it in the stack
                        stack.Push(result);
                        break;
                    }
                default:
                    {
                        // places the number into the stack
                        int result = int.Parse(str);
                        stack.Push(result);
                        break;
                    }
            }
        }
        public int Result
        {
            get
            {
                // do the code to return the last value
                // return the top value (or the result)
                return stack.Top;
            }
        }
    }

    //Clients' view. 
    class Program
    {
        static void Main(string[] args)
        {
            RPN rpn = new RPN();

            while (true)
            {
                string str;

                Console.Write("RPN>");
                str = Console.ReadLine();

                rpn.Process(str);

                Console.WriteLine("={0}", rpn.Result);
            }
        }
    }
}
