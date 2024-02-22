namespace DSAndAlgoConcepts.DivideAndConquer
{
    internal class MergeSortOnStringArray
    {
        //static void Main(string[] args)
        //{
        //    var arr = new string[] { "sun", "earth", "mars", "mercury", "jupiter", "saturn", "uranus" };
        //    MergeSort(arr, 0, arr.Length - 1);

        //}

        static void MergeSort(string[] arr, int left, int right)
        {
            Console.WriteLine("({0},{1})", left, right);
            if (left >= right) { return; }
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);


        }

        static void Merge(string[] arr, int left, int mid, int right)
        {
            int p1 = left;
            int p2 = mid + 1;
            int p3 = 0;
            var res = new string[right - left + 1];
            while (p1 <= mid && p2 <= right)
            {
                if (arr[p1].CompareTo(arr[p2]) <= 0)
                {
                    res[p3] = arr[p1];
                    p1++;
                    p3++;
                }
                else
                {
                    res[p3] = arr[p2];
                    p2++;
                    p3++;
                }
            }

            while (p1 <= mid)
            {
                res[p3] = arr[p1];
                p1++;
                p3++;
            }
            while (p2 <= right)
            {
                res[p3] = arr[p2];
                p2++;
                p3++;
            }

            for (int i = 0; i < res.Length; i++)
            {
                arr[i + left] = res[i];
            }
        }
    }
}
