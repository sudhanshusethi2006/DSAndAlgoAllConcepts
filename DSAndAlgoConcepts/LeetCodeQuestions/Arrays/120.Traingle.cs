namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class TraingleArray
    {
        //static void Main(string[] args)
        //{
        //    List<List<int>> input = new List<List<int>>() { new List<int> { -1 }, new List<int> { 2, 3 }, new List<int> { 1, -1, -3 } };
        //    //new List<int> { 4, 1, 8, 3 } };
        //    Solution obj = new Solution();
        //    obj.MinimumTotal(input);
        //}
    }

    public class Solution
    {
        public int MinimumTotal(List<List<int>> triangle)
        {
            if (triangle.Count == 0) return 0;
            if (triangle.Count == 1) return triangle[0][0];

            int sum = triangle[0][0];
            int lastIndex = 0;
            for (int i = 1; i < triangle.Count; i++)
            {
                int min = Math.Min(triangle[i][lastIndex], triangle[i][lastIndex + 1]);
                lastIndex = triangle[i][lastIndex + 1] < triangle[i][lastIndex] ? lastIndex + 1 : lastIndex;
                sum += min;
            }

            return sum;


        }
    }
}
