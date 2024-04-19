using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class ReverseStackClass
    {
        //static void Main(string[] args)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);

        //    Console.WriteLine(string.Join('\n', stack));
        //    ReverseStack(stack);
        //    Console.WriteLine(string.Join('\n', stack));


        //}
        static void ReverseStack(Stack<int> stack)
        {
            if (stack.Count == 0) return;

            var top = stack.Pop();
            ReverseStack(stack);
            PushAtBottomOfStack(stack, top);
        }

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
