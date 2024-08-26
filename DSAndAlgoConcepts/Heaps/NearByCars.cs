namespace DSAndAlgoConcepts.Heaps
{
    internal class NearByCars
    {
        class Point
        {
            public int x;
            public int y;
            public int distanceFromOrigin;
            public int index;
            public Point(int x, int y, int index)
            {
                this.x = x;
                this.y = y;
                this.index = index;
                distanceFromOrigin = Convert.ToInt32(Math.Pow(x, 2)) + Convert.ToInt32(Math.Pow(y, 2));
            }

        }
        //static void Main(string[] args)
        //{
        //    CalculateNearByCars();

        //}

        private static void CalculateNearByCars()
        {
            int[,] pts = { { 3, 3 }, { 5, -1 }, { -2, 4 } };

            int k = 2;

            PriorityQueue<Point, int> priorityQueue = new PriorityQueue<Point, int>();

            for (int i = 0; i < pts.GetLength(0); i++)
            {
                var point = new Point(pts[i, 0], pts[i, 1], i);
                priorityQueue.Enqueue(point, point.distanceFromOrigin);
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(priorityQueue.Dequeue().index);
            }
        }
    }
}
