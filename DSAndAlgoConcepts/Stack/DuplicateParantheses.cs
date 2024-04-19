using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class DuplicateParantheses
    {
        //static void Main(string[] args)
        //{
        //    string s = "((a+b)+(c+d))";
        //    string s2 = "((a_b))";
        //    Console.WriteLine(hasDuplicateParantheses(s));
        //    Console.WriteLine(hasDuplicateParantheses(s2));
        //}

        static bool hasDuplicateParantheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c != ')')
                    stack.Push(c);
                else
                {
                    int count = 0;

                    while (stack.Peek() != '(')
                    {
                        stack.Pop();
                        count++;
                    }

                    if (count == 0)
                        return true;
                    stack.Pop();
                }
            }
            return false;
        }
    }
}
