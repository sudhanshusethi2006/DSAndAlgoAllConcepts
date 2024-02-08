namespace DSAndAlgoConcepts.SlidingWindow
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        //static void Main(string[] args)
        //{
        //    var s = "abcabcbb";
        //    LengthOfLongestSubstring(s);
        //}


        public static int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;
            while (b_pointer < s.Length)
            {
                if (!dict.ContainsKey(s[b_pointer]))
                {
                    dict.Add(s[b_pointer], 0);
                    b_pointer++;
                    max = Math.Max(dict.Count, max);
                }
                else
                {
                    dict.Remove(s[a_pointer]);
                    a_pointer++;
                }
            }
            return max;

        }

    }
}
