namespace DSAndAlgoConcepts.Heaps
{
    internal class ConnectNRopes
    {
        //static void Main(string[] args)
        //{
        //    ConnectNRopesWithMinimumCost();
        //}

        private static void ConnectNRopesWithMinimumCost()
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            int[] ropes = { 4, 3, 2, 6 };
            for (int i = 0; i < ropes.Length; i++)
            {
                priorityQueue.Enqueue(ropes[i], ropes[i]);
            }
            int sum = 0;
            while (priorityQueue.Count > 1)
            {
                int min1 = priorityQueue.Dequeue();
                int min2 = priorityQueue.Dequeue();
                sum += min1 + min2;
                priorityQueue.Enqueue(min1 + min2, min1 + min2);
            }
            Console.WriteLine(sum);
        }
    }
}
