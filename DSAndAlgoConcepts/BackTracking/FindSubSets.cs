namespace DSAndAlgoConcepts.BackTracking
{
    internal class FindSubSetsClass
    {
        // find all subsets of given string 
        // abc 
        //2 ^n subsets 


        public static void FindSubsets(string str, string ans, int i)
        {

            if (i == str.Length)
            { Console.WriteLine(ans); return; }
            //recursion
            //yes choice
            FindSubsets(str, ans + str[i], i + 1);

            //no choice
            FindSubsets(str, ans, i + 1);
        }

        //static void Main(string[] args)
        //{
        //    var s = "abc";
        //    var ans = "";
        //    FindSubsets(s, ans, 0);
        //}


    }
}
