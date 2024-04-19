namespace DSAndAlgoConcepts.BackTracking
{
    internal class FindPermutations
    {
        //n!
        public static void Permutations(string s, string ans)
        {
            if (s.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }

            // recursion 

            for (int i = 0; i < s.Length; i++)
            {
                string NewStr = s.Substring(0, i) + s.Substring(i + 1);
                Permutations(NewStr, ans + s[i]);
            }
        }

        //static void Main(string[] args)
        //{
        //    Permutations("abc", "");
        //}
    }
}
