namespace DSAndAlgoConcepts.Hashing
{
    internal class Anagram
    {
        public static bool isAnagram(string s1, string s2)
        {
            Dictionary<char, int> counts = new();

            counts = s1.GroupBy(c => c).ToDictionary(x => x.Key, x => x.Count());
            for (int i = 0; i < s2.Length; i++)
            {
                if (counts.ContainsKey(s1[i]))
                {
                    if (counts[s1[i]] == 1)
                        counts.Remove(s1[i]);

                    else
                        counts[s1[i]]--;
                }
                else
                    return false;

            }
            return counts.Count == 0;
        }


        interface Ifirst
        {
            bool IsDefined(string routineName);
            string Suggest(string seed = null);
        }


        //static void Main(string[] args)
        //{
        //    string s1 = "race";
        //    string s2 = "care";
        //    var count = 0;
        //    string s = "";
        //    List<string> s3 = new();
        //    s3.Add("hello");
        //    s3.Add("hi");
        //    s3.Add("hey");
        //    s3.Add("hello2");

        //    var test = s3.Any(x => x.Equals("hi"));

        //    s = "hi";
        //    while (s3.Any(x => x.Equals(s)))
        //    {
        //        s = string.Format("hello{0}", ++count);
        //        Console.WriteLine("yes");
        //    }


        //    Console.WriteLine(isAnagram(s1, s2));
        //}
    }
}
