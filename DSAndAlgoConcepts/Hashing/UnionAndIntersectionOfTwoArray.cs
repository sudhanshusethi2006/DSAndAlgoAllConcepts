namespace DSAndAlgoConcepts.Hashing
{
    internal class UnionAndIntersectionOfTwoArray
    {
        //static void Main(string[] args)
        //{
        //    var arr1 = new int[] { 7, 3, 9 };
        //    var arr2 = new int[] { 6, 3, 9, 2, 9, 4 };

        //    UnionAndIntersection(arr1, arr2);
        //}

        private static void UnionAndIntersection(int[] arr1, int[] arr2)
        {
            var list = arr1.Union(arr2);
            var list2 = arr1.Intersect(arr2);

            // union 

            HashSet<int> unionHashset = new HashSet<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                unionHashset.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                unionHashset.Add(arr2[i]);
            }

            // intersection

            HashSet<int> intersectionHashset = new HashSet<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                intersectionHashset.Add(arr1[i]);
            }

            var count = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (intersectionHashset.Contains(arr2[i]))
                {
                    count++;
                    intersectionHashset.Remove(arr2[i]);
                }
            }
        }
    }
}
