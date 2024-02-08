namespace DSAndAlgoConcepts.Arrays
{
    internal class ArrayRotation
    {
        //static void Main(string[] args)
        //{

        //    ArrayRightRotation_Optimized_NoExtraSpace(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);

        //    ArrayLeftRotation_Optimized_NoExtraSpace(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);
        //    Console.WriteLine(string.Join(",", ArrayRightRotation_UnOptimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2)));
        //    Console.WriteLine(new string('-', 20));
        //    Console.WriteLine(string.Join(",", ArrayLeftRotation_UnOptimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2)));
        //    Console.WriteLine(new string('-', 10) + "Optimized" + new string('-', 10));
        //    Console.WriteLine(string.Join(",", ArrayRightRotation_Optimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2)));
        //    Console.WriteLine(new string('-', 20));
        //    Console.WriteLine(string.Join(",", ArrayLeftRotation_Optimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2)));


        //}

        public static int[] ArrayRightRotation_UnOptimized(int[] arr, int k)
        {

            for (int i = 0; i < k; i++)
            {
                int temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = temp;
            }
            return arr;
        }

        public static int[] ArrayLeftRotation_UnOptimized(int[] arr, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp;
            }
            return arr;

        }

        public static int[] ArrayRightRotation_Optimized(int[] arr, int k)
        {

            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[(i + k) % arr.Length] = arr[i];
            }
            int[] nums = new int[arr.Length];
            nums = (int[])arr.Clone();
            return temp;
        }

        public static int[] ArrayRightRotation_Optimized_NoExtraSpace(int[] arr, int k)
        {

            k = k % arr.Length;

            int n = arr.Length;

            reverseNum(arr, 0, n - 1);
            reverseNum(arr, 0, k - 1);
            reverseNum(arr, k, n - 1);

            return arr;
        }
        private static void reverseNum(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }




        public static int[] ArrayLeftRotation_Optimized(int[] arr, int k)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[(arr.Length + (i - k)) % arr.Length] = arr[i];
            }
            return temp;

        }

        public static int[] ArrayLeftRotation_Optimized_NoExtraSpace(int[] arr, int k)
        {
            k = k % arr.Length;
            int n = arr.Length;

            reverseNum(arr, 0, n - 1);
            reverseNum(arr, n - k, n - 1);
            reverseNum(arr, 0, n - k - 1);
            return arr;
        }





    }
}
