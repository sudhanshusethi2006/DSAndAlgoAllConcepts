namespace DSAndAlgoConcepts.BackTracking
{
    internal class KeyPadProblemLeetCode
    {
        static char[][] KeyPad =
         {
           new  char[] { },
           new char[] { },
           new char[] {'a','b','c'},//2
           new char[] { 'd','e','f' },//3
           new char[] { 'g','h','i' },
           new char[] { 'j','k','l' },
           new char[] { 'm','n','o' },
           new char[] { 'p','q','r','s' },
           new char[] { 't','u','v' },
           new char[] { 'w','x','y','z' },
        };
        static List<String> ProblemCodes = new List<String>();
        public static void KeyPadProblem(int pos, string outPutStrings, string inputNumbers)
        {
            if (pos == inputNumbers.Length)
            {
                ProblemCodes.Add(outPutStrings);
                Console.WriteLine(outPutStrings);

            }
            else
            {
                var currentNumber = inputNumbers[pos];
                var CurrentNumberWithKeyPasIndex = currentNumber - '0';
                //OR
                // var number = Int32.Parse(currentNumber.ToString());
                var letters = KeyPad[CurrentNumberWithKeyPasIndex];
                if (!letters.Any())
                    KeyPadProblem(pos + 1, outPutStrings, inputNumbers);
                for (int i = 0; i < letters.Length; i++)
                {
                    KeyPadProblem(pos + 1, outPutStrings + letters[i], inputNumbers);
                }

            }

        }

        //static void Main(string[] args)
        //{
        //    string inputNumbers = "234";
        //    KeyPadProblem(0, "", inputNumbers);
        //}
    }
}
