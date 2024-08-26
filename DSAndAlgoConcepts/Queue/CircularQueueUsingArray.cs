using DSAndAlgoConcepts.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    internal class CircularQueueUsingArray
    {
        class CircularQueue
        {
            static int[] arr;
            static int front;
            static int rear;
            static int size;
            public CircularQueue(int n)
            {
                arr = new int[n];
                front = -1;
                rear = -1;
                size = n;

            }

            public bool isEmpty() => front == -1 && rear == -1;

            public bool isFull() => (rear + 1) % size == front;

            public void Add(int n)
            {
                if (isFull()) return;
                if (front == -1) front++;
                rear = (rear + 1) % size;
                arr[rear] = n;

            }

            public int Remove()
            {
                int temp = arr[front];

                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % size;
                }
                return temp;
            }
            public int Peek() => arr[front];

        }

        //static void Main(string[] args)
        //{
        //    CircularQueue circularQueue = new CircularQueue(3);
        //    circularQueue.Add(1);
        //    circularQueue.Add(2);
        //    circularQueue.Add(3);
        //    circularQueue.Remove();
        //    circularQueue.Add(4);
        //    circularQueue.Remove();
        //}
    }
}
