using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{

    internal class QueueUsingArray
    {

        class Queue
        {
            static int[] arr;
            static int rear;
            static int size;

            public Queue(int n)
            {
                arr = new int[n];
                size = n;
                rear = -1;
            }

            public bool isEmpty() { return rear == -1; }

            public void Add(int n)
            {
                if (rear == size - 1) return;
                rear++;
                arr[rear] = n;
            }

            public int Remove()
            {
                if (isEmpty()) return -1;
                int front = arr[0];
                for (int i = 0; i < rear; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[rear] = 0;
                rear--;
                return front;
            }

            public int Peek() => arr[0];
        }
        //static void Main(string[] args)
        //{
        //    Queue queue = new Queue(5);
        //    queue.Add(1);
        //    queue.Add(2);
        //    queue.Add(3);
        //    queue.Add(4);
        //    queue.Remove();
        //}
    }
}
