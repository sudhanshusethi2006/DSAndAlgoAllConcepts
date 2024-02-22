namespace DSAndAlgoConcepts.Arrays
{
    //169. Majority Element
    //Given an array nums of size n, return the majority element.

    //The majority element is the element that appears more than ⌊n / 2⌋ times.
    //You may assume that the majority element always exists in the array.

    internal class BoyerMooreVotingAlgorithm
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
        //    MajorityElement(nums);
        //    MajorityElement_BruteForce(nums);
        //}


        //Boyer Moore Algorithm
        static int MajorityElement(int[] nums)
        {
            // firt take consider the first element of the array as winner with votes=1
            int winner = nums[0];
            int votes = 1;

            // now loop through the array and if the 
            // next element is winner , update votes
            // next element is not winner 
            // a. if votes is 0, update the winner
            // b. if votes if more than 0, decrease the votes

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == winner) votes++;
                else
                {
                    if (votes == 0)
                    {
                        winner = nums[i];
                        votes = 1;
                    }
                    else
                        votes--;
                }
            }
            return winner;
        }

        static int MajorityElement_BruteForce(int[] nums)
        {
            int winner = 0;
            int MaxVotes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int votes = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[i] == nums[j])
                        votes++;
                }
                if (votes > MaxVotes)
                {
                    winner = nums[i];
                    MaxVotes = votes;
                }
            }
            return winner;
        }
    }
}
