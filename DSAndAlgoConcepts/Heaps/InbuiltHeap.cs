namespace DSAndAlgoConcepts.Heaps
{
    internal class InbuiltHeap
    {
        //static void Main(string[] args)
        //{
        //    PQ();
        //}

        private static void PQ()
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(new ArrangeInReverseOrder());
            // Or 

            PriorityQueue<int, int> pq2 = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => -x.CompareTo(y)));
            pq.Enqueue(4, 2);
            pq.Enqueue(1, 3);
            pq.Enqueue(3, 1);

            pq.Enqueue(7, 4);


            pq2.Enqueue(4, 2);
            pq2.Enqueue(1, 3);
            pq2.Enqueue(3, 1);

            pq2.Enqueue(7, 4);
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Peek());
                pq.Dequeue();
            }
        }

        public class ArrangeInReverseOrder : IComparer<int>
        {
            public int Compare(int x, int y)
            {

                return y - x;
            }
        }
    }
}
