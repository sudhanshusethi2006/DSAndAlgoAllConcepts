namespace DSAndAlgoConcepts.Heaps
{
    internal class WeakestSoldier
    {
        class Row : IComparable<Row>
        {
            int soldiers;
            int index;

            public Row(int soldiers, int index)
            {
                this.soldiers = soldiers;
                this.index = index;
            }
            public int CompareTo(Row? r2)
            {
                if (this.soldiers == r2.soldiers)
                    return this.index - r2.index;
                else return this.soldiers - r2.soldiers;
            }
        }
        //static void Main(string[] args)
        //{
        //    var arr = new int[4][] { new int[4] { 1, 0, 0, 0 }, new int[4] { 1, 1, 1, 1 }, new int[4] { 1, 0, 0, 0 }, new int[4] { 1, 0, 0, 0 } };
        //    int k = 2;
        //    GetWeakestSolider(arr, k);
        //}

        private static void GetWeakestSolider(int[][] arr, int k)
        {
            PriorityQueue<int, Row> priorityQueue = new PriorityQueue<int, Row>();


            PriorityQueue<int, int> pq2 = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => -x.CompareTo(y)));


            for (int i = 0; i < arr.Length; i++)
            {
                int oneCount = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 1)
                        oneCount++;
                }
                priorityQueue.Enqueue(i, new Row(oneCount, i));
            }

            var ans = new int[k];
            for (int i = 0; i < k; i++)
            {
                ans[i] = priorityQueue.Dequeue();

            }
        }
    }
}
