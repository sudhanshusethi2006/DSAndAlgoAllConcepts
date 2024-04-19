using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class ValidParantheses
    {
        //static void Main(string[] args)
        //{
        //    string s = "(()[]{})";
        //    string s2 = "{}([)";
        //    var res = isValid(s);
        //    Console.WriteLine(res);
        //    Console.WriteLine(isValid(s2));
        //}

        static bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '{' || c == '(' || c == '[')
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    var top = stack.Pop();
                    if ((c == ')' && top == '(') || (c == '}' && top == '{') || (c == ']' && top == '[')) continue;
                    else return false;
                }
            }
            if (stack.Count > 0) return false;
            return true;
        }
    }
}
