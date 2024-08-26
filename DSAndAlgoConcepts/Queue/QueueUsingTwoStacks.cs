using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    internal class QueueUsingTwoStacks
    {
        static Stack<int> s1 = new Stack<int>();

        static Stack<int> s2 = new Stack<int>();

        static void Add(int data)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            s1.Push(data);

            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        static void Remove()
        {
            if (s1.Count > 0)
            {
                s1.Pop();
            }
        }
    }
}
