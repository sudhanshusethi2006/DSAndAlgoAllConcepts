using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class ReverseStringUsingStack
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Reverse("sudhanshu"));
        //}


        static string Reverse(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                stack.Push(c);
            }

            StringBuilder stringBuilder = new StringBuilder();
            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }
            return stringBuilder.ToString();
        }

    }
}
