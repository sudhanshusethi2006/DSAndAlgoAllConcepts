namespace DSAndAlgoConcepts.LeetCodeQuestions.Strings
{
    internal class CountVowelStringsInRanges_2559
    {
        public static int[] VowelStrings(string[] words, int[][] queries)
        {
            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var dict = new Dictionary<int, int>();
            var result = new int[queries.Length];
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {

                var word = words[i];
                if (Array.IndexOf(vowels, word[0]) > -1 && Array.IndexOf(vowels, word[word.Length - 1]) > -1)
                {
                    count++;
                }
                dict.Add(i, count);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                var arr = queries[i];
                if (arr[0] == 0)
                    result[i] = dict[arr[1]];
                else
                {
                    var res = dict[arr[1]] - dict[arr[0] - 1];
                    result[i] = res;
                }

            }
            return result;

        }
        //static void Main(string[] args)
        //{
        //    var words = new string[] { "aba", "bcb", "ece", "aa", "e" };

        //    var queries = new int[3][]
        //    {
        //        new int[2]{ 0,2},
        //        new int[2] { 1,4},
        //        new int[2]{1,1 }
        //    };

        //    Console.WriteLine(string.Join(", ", VowelStrings(words, queries)));
        //}
    }
}
