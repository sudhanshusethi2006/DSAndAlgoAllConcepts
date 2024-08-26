namespace DSAndAlgoConcepts.LeetCodeQuestions
{
    class KthLargestInAStream
    {
        //703. Kth Largest Element in a Stream
        internal class KthLargest
        {
            List<int> heap = new List<int>();

            int k;

            public KthLargest(int k, int[] nums)
            {
                this.k = k;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (heap.Count < k)
                    {
                        heap.Add(nums[i]);
                    }
                    else
                    {
                        heap.Add(nums[i]);
                        heap.Sort();
                        heap.RemoveAt(0);
                    }
                }
            }

            public int Add(int val)
            {
                heap.Add(val);
                heap.Sort();
                if (heap.Count > k)
                    heap.RemoveAt(0);

                return heap[0];
                //list.Add(val);
                //list.Sort((a, b) => b - a);
                //return list.ToArray()[k - 1];
            }


        }
        //static void Main(string[] args)
        //{
        //    KthLargest kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
        //    var res = kthLargest.Add(3);
        //    var res2 = kthLargest.Add(5);
        //    var res3 = kthLargest.Add(10);
        //    var res4 = kthLargest.Add(9);

        //}
    }
}
