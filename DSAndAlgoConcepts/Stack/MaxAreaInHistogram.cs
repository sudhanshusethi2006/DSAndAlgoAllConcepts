using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Stack
{
    internal class MaxAreaInHistogram
    {
        //static void Main(string[] args)
        //{
        //    var heights = new int[] { 2, 1, 5, 6, 2, 3 };

        //    var maxarea = maxArea(heights);
        //}

        static int maxArea(int[] heights)
        {
            int maxArea = 0;
            int[] nextSmallestRight = new int[heights.Length];
            int[] nextSmallestLeft = new int[heights.Length];

            // next smallest right side 

            Stack<int> stack = new Stack<int>();
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();

                if (stack.Count == 0)
                    nextSmallestRight[i] = -1;

                else
                    nextSmallestRight[i] = stack.Peek();

                stack.Push(i);
            }


            // we need to find next smallest left side
            stack = new Stack<int>();

            for (int i = 0; i < heights.Length; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();

                if (stack.Count == 0)
                    nextSmallestLeft[i] = -1;

                else
                    nextSmallestLeft[i] = stack.Peek();

                stack.Push(i);
            }





            // width= j(next smallest right) - i(next smallest left) -1 
            // 
            for (int i = 0; i < heights.Length; i++)
            {
                int height = heights[i];
                int width = nextSmallestRight[i] - nextSmallestLeft[i] - 1;
                maxArea = Math.Max(maxArea, height * width);
            }

            return maxArea;
        }
    }
}
