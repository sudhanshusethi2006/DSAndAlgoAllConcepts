using System.Text;

namespace DSAndAlgoConcepts.Recursion
{
    internal class RemoveDuplicateInString
    {
        //static void Main(string[] args)
        //{
        //    RemoveDuplicate("hhhhheeellllooooo", 0, new StringBuilder(), new bool[26]);
        //}


        static void RemoveDuplicate(string s, int i, StringBuilder sb, bool[] map)
        {
            if (i == s.Length)
            {
                Console.WriteLine(sb.ToString()); return;
            }
            if (map[s[i] - 'a'])
            {
                RemoveDuplicate(s, i + 1, sb, map);
            }
            else
            {
                sb.Append(s[i]);
                map[s[i] - 'a'] = true;
                RemoveDuplicate(s, i + 1, sb, map);
            }
        }
    }
}
