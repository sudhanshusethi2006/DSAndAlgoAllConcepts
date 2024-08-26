using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.ArrayList
{
    internal class ContainerWithMostWater
    {
        public static int MaxWaterStored_BruteForce(List<int> list)
        {
            int maxWater = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    int area = Math.Min(list[i], list[j]) * (j - i);
                    maxWater = Math.Max(maxWater, area);
                }

            }
            return maxWater;
        }

        public static int MaxWaterStored_TwoPointers(List<int> list)
        {
            int leftPointer = 0;
            int rightPointer = list.Count - 1;

            int maxArea = 0;
            while (leftPointer < rightPointer)
            {
                int currentWaterArea = (rightPointer - leftPointer) * Math.Min(list[leftPointer], list[rightPointer]);
                maxArea = Math.Max(maxArea, currentWaterArea);
                if (leftPointer < rightPointer)
                    leftPointer++;
                else
                    rightPointer--;
            }

            return maxArea;
        }
        //static void Main(string[] args)
        //{
        //    var heights = new List<int>
        //    {
        //        1,
        //        8,
        //        6,
        //        2,
        //        5,
        //        4,
        //        8,
        //        3,
        //        7
        //    };
        //    Console.WriteLine(MaxWaterStored_BruteForce(heights));
        //    Console.WriteLine(MaxWaterStored_TwoPointers(heights));

        //}
    }
}
