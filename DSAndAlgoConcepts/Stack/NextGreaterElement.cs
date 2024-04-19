using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class NextGreaterElement
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 8, 0, 1, 3 };
            int[] arrCopy = arr.Select(c => c).ToArray();
            var res = NaiveApproach(arr);
            var res2 = NextGreaterElementOptimized(arr);
        }

        static int[] NaiveApproach(int[] arr)
        {
            int[] nextGreater = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int nextGreatest = -1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        nextGreatest = arr[j];
                        break;
                    }

                }
                nextGreater[i] = nextGreatest;
            }
            return nextGreater;

        }
        static int[] NextGreaterElementOptimized(int[] arr)
        {
            int[] nextGreater = new int[arr.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && arr[stack.Peek()] <= arr[i])
                    stack.Pop();

                if (stack.Count == 0)
                    nextGreater[i] = -1;

                else
                    nextGreater[i] = arr[stack.Peek()];

                stack.Push(i);
            }
            return nextGreater;
        }
    }
}
