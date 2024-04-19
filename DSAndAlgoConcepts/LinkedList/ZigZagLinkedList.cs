namespace DSAndAlgoConcepts.LinkedList
{
    internal class ZigZagLinkedList
    {
        // Input:  1->2->3->4....n-1->n
        //Output: 1->n>2>n-1>3->n-2
        //static void Main(string[] args)
        //{
        //    LinkedListClass ll = new LinkedListClass();
        //    ll.AddFirst(1);
        //    ll.AddFirst(2);
        //    ll.AddFirst(3);
        //    ll.AddLast(4);
        //    ll.AddLast(5);
        //    ll.AddLast(6);
        //    ll.AddAtIndex(4, 7);


        //    ZigZag();
        //}

        static public void ZigZag()
        {
            LinkedListClass.Node slow = LinkedListClass.head;
            LinkedListClass.Node fast = LinkedListClass.head.next;

            while (slow != null && fast != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }



            LinkedListClass.Node first = null;
            LinkedListClass.Node second = slow.next;
            slow.next = null;
            LinkedListClass.Node third;

            while (second != null)
            {
                third = second.next;
                second.next = first;
                first = second;
                second = third;
            }


            LinkedListClass.Node temp1 = LinkedListClass.head;
            LinkedListClass.Node temp2 = first;
            LinkedListClass.Node temp3;
            LinkedListClass.Node temp4;

            while (temp1 != null && temp2 != null)
            {
                temp3 = temp1.next;
                temp1.next = temp2;
                temp4 = temp2.next;
                temp2.next = temp3;

                //update
                temp1 = temp3;
                temp2 = temp4;

            }
        }


    }
}
