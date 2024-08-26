using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    class StackUsingTwoQueues
    {

        private static Queue<int> q1 = new Queue<int>();
        private static Queue<int> q2 = new Queue<int>();

        bool isEmpty => q1.Count == 0 && q2.Count == 0;

        public void Push(int x)
        {
            if (q2.Count == 0)
                q1.Enqueue(x);
            else
                q2.Enqueue(x);
        }

        public int Pop()
        {
            int top = int.MinValue;
            if (q1.Count > 0)
            {
                while (q1.Count > 0)
                {
                    top = q1.Dequeue();
                    if (q1.Count == 0)
                        break;
                    q2.Enqueue(top);
                }
            }
            else
            {
                while (q2.Count > 0)
                {
                    top = q2.Dequeue();
                    if (q2.Count == 0)
                        break;
                    q1.Enqueue(top);
                }
            }


            return top;
        }

        public int Peek()
        {
            int top = int.MinValue;
            if (q1.Count > 0)
            {
                while (q1.Count > 0)
                {
                    top = q1.Dequeue();

                    q2.Enqueue(top);
                }
            }
            else
            {
                while (q2.Count > 0)
                {
                    top = q2.Dequeue();

                    q1.Enqueue(top);
                }

            }
            return top;
        }

    }

    class MainClass
    {
        //static void Main(string[] args)
        //{
        //    StackUsingTwoQueues stackUsingTwoQueues = new StackUsingTwoQueues();
        //    stackUsingTwoQueues.Push(1);
        //    stackUsingTwoQueues.Push(2);
        //    var top1 = stackUsingTwoQueues.Peek();
        //    var pop1 = stackUsingTwoQueues.Pop();
        //}
    }
}
