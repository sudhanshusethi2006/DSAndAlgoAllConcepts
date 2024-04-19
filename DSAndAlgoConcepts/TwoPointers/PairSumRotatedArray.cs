using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.TwoPointers
{
    internal class PairSumRotatedArray
    {
        //static void Main(string[] args)
        //{
        //    // sorted and rotated
        //    int targed = 16;
        //    var list = new int[] { 11, 15, 6, 8, 9, 10 };
        //    Console.WriteLine(pair2SumRoted(list, targed));
        //}

        public static bool pair2SumRoted(int[] arr, int target)
        {
            int pivot = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    pivot = i; break;
            }

            int ptr1 = pivot;  // largest
            int ptr2 = pivot + 1; // smallest 

            while (ptr1 != ptr2)
            {
                if (arr[ptr1] + arr[ptr2] == target)
                    return true;

                if (arr[ptr1] + arr[ptr2] < target)
                {
                    ptr2 = (ptr2 + 1) % arr.Length;
                }
                else
                {
                    ptr1 = (arr.Length + ptr1 - 1) % arr.Length;
                }
            }

            return false;
        }
    }
}
