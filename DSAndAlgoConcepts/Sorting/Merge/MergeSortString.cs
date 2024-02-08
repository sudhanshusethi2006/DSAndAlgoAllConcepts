namespace DSAndAlgoConcepts.Sorting.Merge
{
    internal class MergeSortString
    {
        //static void Main(string[] args)
        //{
        //    string[] arr = new string[] { "sun", "earth", "venus", "mercury", "jupiter" };

        //}

        public static void MergeSort(string[] arr, int left, int right)
        {
            if (left > right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

        }

        //public static Merge(string[] arr, int left,int mid, int right)
        //{
        //    int m2 = mid + 1;
        //    while(left<=mid && m2<= right)
        //    {

        //    }
        //}


    }
}
