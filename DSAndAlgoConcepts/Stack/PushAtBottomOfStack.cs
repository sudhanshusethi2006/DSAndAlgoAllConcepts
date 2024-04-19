using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class PushAtBottomOfStackClass
    {
        //static void Main(string[] args)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);
        //    PushAtBottomOfStack(stack, 4);
        //    Console.WriteLine(string.Join('\n', stack));
        //}

        static void PushAtBottomOfStack(Stack<int> stack, int data)
        {
            if (stack.Count == 0)
            {
                stack.Push(data);
                return;
            }
            int top = stack.Pop();
            PushAtBottomOfStack(stack, data);
            stack.Push(top);
        }
    }
}
