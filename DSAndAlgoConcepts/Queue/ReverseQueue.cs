using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    internal class ReverseQueue
    {
        //static void Main(string[] args)
        //{
        //    Queue<int> input = new Queue<int>();
        //    input.Enqueue(1);
        //    input.Enqueue(2);
        //    input.Enqueue(3);
        //    input.Enqueue(4);
        //    input.Enqueue(5);
        //    input.Enqueue(6);
        //    input.Enqueue(7);
        //    input.Enqueue(8);
        //    input.Enqueue(9);
        //    input.Enqueue(10);

        //    Reverse(input);
        //    Console.WriteLine(string.Join(' ', input));
        //}

        static void Reverse(Queue<int> input)
        {
            Stack<int> stack = new Stack<int>();
            while (input.Count > 0)
            {
                stack.Push(input.Dequeue());
            }
            while (stack.Count > 0)
            {
                input.Enqueue(stack.Pop());
            }
        }
    }
}
