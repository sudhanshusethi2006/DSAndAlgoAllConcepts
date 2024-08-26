namespace DSAndAlgoConcepts.Hashing
{
    internal class LargestSubArrayWithSumZero
    {
        //static void Main(string[] args)
        //{
        //    LargestSubArryaWithSum_0();

        //}

        private static void LargestSubArryaWithSum_0()
        {
            var arr = new int[] { 15, -2, 2, -8, 1, 7, 10, 23 };

            var dict = new Dictionary<int, int>();

            int sum = 0;
            int len = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (dict.ContainsKey(sum))
                {
                    len = Math.Max(len, i - dict[sum]);
                }
                else
                {
                    dict.Add(sum, i);
                }
            }
        }
    }
}
