namespace DSAndAlgoConcepts.LinkedList
{
    internal class CycleFindingFLoydAlgorithm
    {
        static LinkedListClass.Node head;
        //static void Main(string[] args)
        //{
        //    MakeLoopInBetween();
        //    var iscycle = FindLoop();
        //    RemovingLoop();

        //}

        static void MakeCimpleteLoop()
        {
            head = null;
            LinkedListClass ll = new LinkedListClass();
            ll.AddLast(1);
            head = LinkedListClass.head;
            head.next = new LinkedListClass.Node(2);

            head.next.next = new LinkedListClass.Node(3);
            head.next.next.next = new LinkedListClass.Node(4);
            head.next.next.next.next = head;

        }

        static void MakeLoopInBetween()
        {
            LinkedListClass ll = new LinkedListClass();
            ll.AddLast(1);
            head = LinkedListClass.head;
            head.next = new LinkedListClass.Node(2);
            var node3 = new LinkedListClass.Node(3);
            head.next.next = node3;
            head.next.next.next = new LinkedListClass.Node(4);
            head.next.next.next.next = node3;
        }
        public static bool FindLoop()
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) // we want the hash codes of the objec tto be same as well
                    return true;
            }
            return false;
        }

        public static void RemovingLoop()
        {
            // detect loop
            // slow=head
            // move slow and head by 1 , 

            // detect the loop

            var slow = head;
            var fast = head;
            bool isLoop = false;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    isLoop = true;
                    break;
                }
            }
            if (isLoop)
            {
                LinkedListClass.Node prev = null;
                slow = head;
                if (slow == fast)
                {
                    while (slow.next != fast)
                    {
                        slow = slow.next;
                    }
                    slow.next = null;

                }
                else
                {
                    while (slow != fast)
                    {
                        prev = fast;
                        slow = slow.next;
                        fast = fast.next;
                    }
                    prev.next = null;
                }

            }

        }



    }


}
