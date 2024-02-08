namespace DSAndAlgoConcepts.Arrays
{
    internal class ArrayDuplicateElement
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4 };
        //    var res = isElementExistsMultipleTimes(arr);
        //}

        static bool isElementExistsMultipleTimes(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    return true;
                else
                    dict.Add(arr[i], 1);

            }
            return false;
        }
    }
}
