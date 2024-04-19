using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSAndAlgoConcepts.LinkedList.ApnaCollegePracticeQuestions;
using static System.Net.Mime.MediaTypeNames;

namespace DSAndAlgoConcepts.LinkedList
{
    internal class SwappingNodesLinkedList
    {
        static LinkedListClass.Node head;

        //static void Main(string[] args)
        //{
        //    LinkedListClass ll = new LinkedListClass();
        //    ll.AddFirst(1);
        //    ll.AddLast(2);
        //    ll.AddLast(3);
        //    ll.AddLast(6);
        //    ll.AddLast(7);
        //    //ll.AddLast(8);
        //    //ll.AddLast(3);
        //    //ll.AddLast(0);
        //    //ll.AddLast(9);
        //    //ll.AddLast(5);
        //    head = LinkedListClass.head;

        //    // SwappingNodesWithTwoKeysUniqueLinkedList(2, 4);
        //    SwappingKthNodesFromBeginningToEnd(1);

        //}
        static void SwappingNodesWithTwoKeysUniqueLinkedList(int X, int Y)
        {

            var temp = head;
            var prev1 = head;
            var prev2 = head;

            while (temp.data != X)
            {
                prev1 = temp;
                temp = temp.next;
            }

            while (temp.data != Y)
            {
                prev2 = temp;
                temp = temp.next;
            }

            temp = prev1.next;
            var temp2 = prev2.next;


            var next = temp.next;
            temp.next = temp2.next;
            temp2.next = next;

            prev1.next = temp2;
            prev2.next = temp;


        }
        static void SwappingKthNodesFromBeginningToEnd(int K)
        {
            if (head == null || head.next == null) return;
            int n = 0;
            var temp = head;
            while (temp != null)
            {
                temp = temp.next;
                n++;
            }

            var kFromEnd = n - K + 1;

            if (K == kFromEnd)
                return;


            LinkedListClass.Node temp1;
            var temp2 = head;
            var prev1 = head;
            var prev2 = head;
            int i = 1;


            if (K < kFromEnd)
            {

                while (i < K)
                {
                    prev1 = temp2;
                    temp2 = temp2.next;
                    i++;
                }
                temp1 = temp2;
                while (i <= n - K)
                {
                    prev2 = temp2;
                    temp2 = temp2.next;
                    i++;
                }
            }
            else
            {
                while (i <= n - K)
                {
                    prev1 = temp2;
                    temp2 = temp2.next;
                    i++;
                }
                temp1 = temp2;
                while (i < K)
                {
                    prev2 = temp2;
                    temp2 = temp2.next;
                    i++;
                }
            }
            if (Math.Abs(kFromEnd - K) == 1)
            {
                if (!prev1.Equals(temp1))
                    prev1.next = temp2;
                var next2 = temp2.next;
                temp2.next = temp1;
                temp1.next = next2;
                if (next2 == null)
                    head = temp2;
                return;
            }
            var next = temp2.next;
            temp2.next = temp1.next;
            temp1.next = next;
            if (!prev1.Equals(temp1))
                prev1.next = temp2;
            prev2.next = temp1;
            if (next == null)
                head = temp2;
        }

    }


}
