namespace DSAndAlgoConcepts.Heaps
{

    internal class SlidingwindowMaximum
    {
        public class Pair : IComparable<Pair>
        {
            public int val;
            public int index;

            public Pair(int val, int index)
            {
                this.val = val;
                this.index = index;
            }

            public int CompareTo(Pair? p2)
            {
                return p2.val - this.val;
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
        //    int k = 3;
        //    GetMaximumWindows(arr, k);
        //}

        private static void GetMaximumWindows(int[] arr, int k)
        {
            int[] res = new int[arr.Length - k + 1];

            PriorityQueue<Pair, Pair> priorityQueue = new PriorityQueue<Pair, Pair>();

            for (int i = 0; i < k; i++)
            {
                priorityQueue.Enqueue(new Pair(arr[i], i), new Pair(arr[i], i));
            }

            res[0] = priorityQueue.Peek().val;

            for (int i = k; i < arr.Length; i++)
            {
                while (priorityQueue.Count > 0 && priorityQueue.Peek().index <= i - k)
                {
                    priorityQueue.Dequeue();
                }
                priorityQueue.Enqueue(new Pair(arr[i], i), new Pair(arr[i], i));
                res[i - k + 1] = priorityQueue.Peek().val;
            }

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
