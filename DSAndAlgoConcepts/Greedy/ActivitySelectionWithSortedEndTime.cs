using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Greedy
{
    internal class ActivitySelectionWithSortedEndTime
    {
        //static void Main(string[] args)
        //{
        //    int[] activitystartTime = new int[] { 1, 3, 0, 5, 8, 5 };
        //    int[] activityendTime = new int[] { 2, 4, 6, 7, 9, 9 }; // sorted 
        //    MaxActivities(activitystartTime, activityendTime);
        //}

        static void MaxActivities(int[] activitystartTime, int[] activityendTime)
        {
            int maxActivity = 0;
            var activityStartTimes = new List<int>();

            // assign first activity 

            maxActivity = 1;
            int lastEndtime = activityendTime[0];
            activityStartTimes.Add(0);
            for (int i = 1; i < activityendTime.Length; i++)
            {
                if (activitystartTime[i] > lastEndtime)
                {
                    activityStartTimes.Add(i);
                    maxActivity++;
                    lastEndtime = activityendTime[i];
                }
            }

            Console.WriteLine("Total Activties possible" + maxActivity);
            Console.WriteLine(string.Join(",", activityStartTimes));

        }
    }
}
