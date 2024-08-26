namespace DSAndAlgoConcepts.Hashing
{
    internal class subArraySumEqualToK
    {
        //static void Main(string[] args)
        //{
        //    //var arr = new int[] { 10, 2, -2, -20, 10 };
        //    //int k = -10;
        //    var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int k = 9;

        //    LargestSubArryaWithSum_K(arr, k);
        //}
        private static void LargestSubArryaWithSum_K(int[] arr, int k)
        {

            var dict = new Dictionary<int, int>();
            // sum, count
            dict.Add(0, 1);
            int sum = 0;
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (dict.ContainsKey(sum - k))
                {
                    ans += dict[sum - k];
                }
                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }

            }
            Console.WriteLine(ans);
        }


    }


}
