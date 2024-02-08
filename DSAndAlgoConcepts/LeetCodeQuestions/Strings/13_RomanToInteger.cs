namespace DSAndAlgoConcepts.LeetCodeQuestions.Strings
{
    internal class _13_RomanToInteger
    {
        //static void Main(string[] args)
        //{
        //    string s = "III";
        //    var number = RomanToInt(s);
        //}
        public static int RomanToInt(string s)
        {

            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000

            var dict = new Dictionary<string, int>()
            {

                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L",50 },
                { "C",100 },
                { "D", 500 },
                { "M", 1000 },
                { "IV", 4 },
                { "IX", 9 },
                { "XL", 40 },
                { "XC", 90 },
                { "CD", 400 },
                { "CM", 900 },
            };

            int counter = 0;


            int i = s.Length - 2;

            while (i >= -1)
            {
                string number_2_Length = i > -1 ? s.Substring(i, 2) : "";
                if (dict.ContainsKey(number_2_Length))
                {
                    counter += dict[number_2_Length];
                    i -= 2;
                }
                else
                {
                    string number_1_length = s.Substring(i + 1, 1);
                    counter += dict[number_1_length];
                    i--;
                }

            }
            return counter;
        }
    }
}
