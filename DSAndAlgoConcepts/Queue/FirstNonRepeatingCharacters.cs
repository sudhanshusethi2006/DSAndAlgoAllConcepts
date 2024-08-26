using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Queue
{
    internal class FirstNonRepeatingCharacters
    {
        //static void Main(string[] args)
        //{
        //    string s = "aabccxb";
        //    Console.WriteLine(NonRepatingLettersInStreamOfCharacters(s).ToString());
        //}

        static string NonRepatingLettersInStreamOfCharacters(string s)
        {
            StringBuilder sb = new StringBuilder();
            var freq = new int[26];
            var queue = new Queue<char>();
            foreach (char ch in s)
            {
                freq[ch - 'a']++;
                queue.Enqueue(ch);

                while (queue.Count > 0 && freq[queue.Peek() - 'a'] > 1)
                {
                    queue.Dequeue();
                }
                if (queue.Count == 0)

                    sb.Append("-1");

                else

                    sb.Append(queue.Peek());
            }
            return sb.ToString();
        }
    }

}
