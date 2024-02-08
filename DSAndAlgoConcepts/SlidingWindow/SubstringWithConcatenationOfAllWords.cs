using System.Text;

namespace DSAndAlgoConcepts.SlidingWindow
{
    internal class SubstringWithConcatenationOfAllWords
    {
        //static void Main(string[] args)
        //{
        //    var words = new string[] { "bar", "foo", "the" };
        //    string s = "barfoofoobarthefoobarman";
        //    var res = FindSubstring(s, words);
        //}

        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<string> combinations = new List<string>();

            int i = 0;

            while (i < words.Length)
            {
                int j = 0;
                StringBuilder sb = new StringBuilder();
                sb.Append(words[i]);
                while (j < words.Length)
                {
                    if (i == j)
                    {
                        j++;
                        continue;
                    }
                    sb.Append(words[j]);
                    j++;
                }
                combinations.Add(sb.ToString());
                i++;
            }

            var ans = new List<int>();
            foreach (var word in combinations)
            {
                if (s.Contains(word))
                {
                    ans.Add(s.IndexOf(word));
                }
            }

            return ans;

        }
    }
}
