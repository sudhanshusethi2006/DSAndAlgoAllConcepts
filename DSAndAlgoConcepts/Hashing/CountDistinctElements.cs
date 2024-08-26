namespace DSAndAlgoConcepts.Hashing
{
    internal class CountDistinctElements
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 4, 3, 2, 5, 6, 7, 3, 4, 2, 1 };
        //    var count = CountDistinctelements(arr);
        //}

        static int CountDistinctelements(int[] arr)
        {

            //var list = arr.GroupBy(x => x).ToList();
            //return list.Count;

            // OR
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }
            return set.Count;
        }
    }
}
