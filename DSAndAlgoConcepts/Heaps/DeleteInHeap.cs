namespace DSAndAlgoConcepts.Heaps
{
    internal class DeleteInHeap
    {
        //static void Main(string[] args)
        //{
        //    Heap minHeap = new Heap();
        //    minHeap.add(3);
        //    minHeap.add(4);
        //    minHeap.add(1);
        //    minHeap.add(5);
        //    while (minHeap.minHeap.Count > 0)
        //    {
        //        Console.WriteLine(minHeap.minHeap[0]);
        //        minHeap.remove(0);
        //    }

        //}
        class Heap
        {
            public List<int> minHeap = new List<int>();
            public void add(int data)
            {
                minHeap.Add(data);

                var childIndex = minHeap.Count - 1;
                var parentIndex = (childIndex - 1) / 2;
                while (minHeap[childIndex] < minHeap[parentIndex])
                {
                    int temp = minHeap[childIndex];
                    minHeap[childIndex] = minHeap[parentIndex];
                    minHeap[parentIndex] = temp;

                    childIndex = parentIndex;
                    parentIndex = (childIndex - 1) / 2;
                }
            }

            public int remove(int data)
            {
                int dataDeleted = minHeap[0];

                //step 1 swap first and last element
                int temp = minHeap[minHeap.Count - 1];
                minHeap[minHeap.Count - 1] = minHeap[0];
                minHeap[0] = temp;

                // remove last 
                minHeap.RemoveAt(minHeap.Count - 1);

                //heapify

                heapify(0);

                return dataDeleted;
            }

            private void heapify(int root)
            {
                int left = 2 * root + 1;
                int right = 2 * root + 2;

                if (left < minHeap.Count && minHeap[left] < minHeap[root])
                {
                    Swap(root, left);
                    heapify(left);
                }
                if (right < minHeap.Count && minHeap[right] < minHeap[root])
                {
                    Swap(root, right);
                    heapify(right);
                }
            }

            private void Swap(int root, int child)
            {
                int temp = minHeap[root];
                minHeap[root] = minHeap[child];
                minHeap[child] = temp;
            }
        }

    }
}
