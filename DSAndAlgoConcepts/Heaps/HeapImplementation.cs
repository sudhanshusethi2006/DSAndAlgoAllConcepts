namespace DSAndAlgoConcepts.Heaps
{
    internal class HeapImplementation
    {

        // heap is always a binary tree 
        // complete binary tree  --> all levels are completely filled except last one
        // filled from left to right order


        // max heap--> highest element highest priority. parent>=children

        //min heap --> lowest element lowest priority. children node >= parent

        List<int> heap = new List<int>();

        public void add(int data)
        {
            heap.Add(data);

            var childIndex = heap.Count - 1;
            var parentIndex = (childIndex - 1) / 2;
            while (heap[childIndex] < heap[parentIndex])
            {
                int temp = heap[childIndex];
                heap[childIndex] = heap[parentIndex];
                heap[parentIndex] = temp;
            }
        }

    }
}
