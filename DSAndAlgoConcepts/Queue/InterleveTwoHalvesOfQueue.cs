using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    internal class InterleveTwoHalvesOfQueue
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

        //    Interleave(input);
        //    Console.WriteLine(string.Join(' ', input));
        // }

        static void Interleave(Queue<int> input)
        {
            Queue<int> FirstHalf = new Queue<int>();

            int size = input.Count();

            for (int i = 0; i < size / 2; i++)
            {
                FirstHalf.Enqueue(input.Dequeue());
            }


            while (FirstHalf.Count > 0)
            {
                input.Enqueue(FirstHalf.Dequeue());
                input.Enqueue(input.Dequeue());
            }
        }




    }
}
