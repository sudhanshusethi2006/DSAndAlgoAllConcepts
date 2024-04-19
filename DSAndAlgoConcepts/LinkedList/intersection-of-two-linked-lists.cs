using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.LinkedList
{

    internal class ApnaCollegePracticeQuestions
    {
        //Question 1 :
        //static void Main(string[] args)
        //{
        //    int[] arr1 = { 4, 1, 8, 4, 5 };
        //    int[] arr2 = { 5, 6, 1, 8, 4, 5 };
        //    LinkedList list1 = new LinkedList();
        //    foreach (var item in arr1)
        //    {
        //        list1.AddLast(item);
        //    }

        //    LinkedList list2 = new LinkedList();

        //    foreach (var item in arr2)
        //    {
        //        list2.AddLast(item);
        //    }

        //    Solution solution = new Solution();
        //    solution.GetIntersectionNode(list1.head, list2.head);
        //}



        class LinkedList
        {
            public ListNode head;
            ListNode tail;

            public void AddLast(int data)
            {
                ListNode newNode = new ListNode(data);
                if (head == null)
                {
                    head = tail = newNode;
                    return;
                }

                tail.next = newNode;
                tail = newNode;

            }
        }


        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
            {
                ListNode temp = headA;
                ListNode temp2 = headB;

                var hashtable = new HashSet<ListNode>();
                var h = new Hashtable();
                while (temp != null)
                {
                    hashtable.Add(temp);
                    temp = temp.next;
                }
                while (temp2 != null)
                {
                    if (hashtable.Contains(temp2))
                        return temp2;
                    temp2 = temp2.next;
                }

                return null;
            }

            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                ListNode temp1 = headA;
                int len1 = 0;
                while (temp1 != null)
                {
                    len1++;
                    temp1 = temp1.next;
                }
                temp1 = headA;
                ListNode temp2 = headB;
                int len2 = 0;
                while (temp2 != null)
                {
                    len2++;
                    temp2 = temp2.next;
                }
                temp2 = headB;
                while (len1 > len2)
                {
                    temp1 = temp1.next;
                    len1--;
                }
                while (len2 > len1)
                {
                    temp2 = temp2.next;
                    len2--;
                }

                while (temp1 != null)
                {
                    if (temp1.Equals(temp2))
                        return temp1;
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                return null;

            }

            public ListNode getIntersectionNode(ListNode headA, ListNode headB)
            {
                //boundary check
                if (headA == null || headB == null) return null;

                ListNode a = headA;
                ListNode b = headB;

                //if a & b have different len, then we will stop the loop after second iteration
                while (a != b)
                {
                    //for the end of first iteration, we just reset the pointer to the head of another linkedlist
                    a = a == null ? headB : a.next;
                    b = b == null ? headA : b.next;
                }

                return a;
            }
        }
    }
}
