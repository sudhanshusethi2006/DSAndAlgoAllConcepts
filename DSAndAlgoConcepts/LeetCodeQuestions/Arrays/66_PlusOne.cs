namespace DSAndAlgoConcepts.LeetCodeQuestions.Arrays
{
    internal class _66_PlusOne
    {
        //static void Main(string[] args)
        //{
        //    PlusOne(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });

        //    // PlusOne(new int[] { 2, 1, 9 });
        //}
        public static int[] PlusOne(int[] digits)
        {
            return AddOneToArray(digits, digits.Length - 1);



        }

        static int[] AddOneToArray(int[] digits, int index)
        {
            if (index >= 0 && digits[index] == 9)
            {
                digits[index] = 0;
                return AddOneToArray(digits, index - 1);
            }
            if (index == -1)
            {
                var hardCopy = new int[digits.Length + 1];


                hardCopy[0] = 1;

                return hardCopy;
            }

            else
            {
                digits[index] += 1;
                return digits;
            }
        }
    }
}
