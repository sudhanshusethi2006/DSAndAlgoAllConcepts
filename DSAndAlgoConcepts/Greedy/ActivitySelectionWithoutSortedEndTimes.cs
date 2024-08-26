using DSAndAlgoConcepts.Stack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Greedy
{
    internal class ActivitySelectionWithoutSortedEndTimes
    {
        //static void Main(string[] args)
        //{
        //    int[] activitystartTime = new int[] { 0, 1, 3, 5, 5, 8 };
        //    int[] activityendTime = new int[] { 6, 2, 4, 9, 7, 9 };
        //    MaxActivities(activitystartTime, activityendTime);


        //}



        static void MaxActivities(int[] activitystartTime, int[] activityendTime)
        {
            int[,] activities = new int[activitystartTime.Length, 3];
            for (int i = 0; i < activitystartTime.Length; i++)
            {
                activities[i, 0] = i;
                activities[i, 1] = activitystartTime[i];
                activities[i, 2] = activityendTime[i];
            }


            // sort 2-D array by col2
            // convert into list of array

            var list = new List<int[]>();
            for (int i = 0; i < activities.GetLength(0); i++)
            {
                list.Add(new int[] { activities[i, 0], activities[i, 1], activities[i, 2], });
            }
            var sortedList = list.OrderBy(x => x[2]).ToArray();

            int maxActivity = 0;
            var activityStartTimes = new List<int>();

            // assign first activity 

            maxActivity = 1;
            int lastEndtime = sortedList[0][2];
            activityStartTimes.Add(0);
            for (int i = 1; i < activityendTime.Length; i++)
            {
                if (sortedList[i][1] > lastEndtime)
                {
                    activityStartTimes.Add(sortedList[i][0]);
                    maxActivity++;
                    lastEndtime = sortedList[i][2];
                }
            }

            Console.WriteLine("Total Activties possible" + maxActivity);
            Console.WriteLine(string.Join(",", activityStartTimes));

        }

    }

    class Arraycomparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
}
