namespace DSAndAlgoConcepts.LinkedList
{
    internal class LinkedListClass
    {
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }


        }

        public static Node head;
        static Node tail;
        static int size = 1;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            size++;
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            size++;
            tail.next = newNode;
            tail = newNode;

        }

        public void AddAtIndex(int index, int data)
        {
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            Node temp = head;
            int i = 0;
            while (i < index - 1)
            {
                temp = temp.next;
                i++;
            }
            Node newNode = new Node(data);
            size++;
            newNode.next = temp.next;
            temp.next = newNode;

        }

        public void RemoveFirst()
        {
            if (head == null)
                return;
            head = head.next;
            size--;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;

            if (head.next == null)
            {
                head = tail = null;
                size--;
                return;
            }
            var temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            tail = temp;
            size--;
        }

        public bool Search(int key)
        {
            var temp = head;

            while (temp != null)
            {
                if (temp.data == key)
                    return true;
                temp = temp.next;
            }
            return false;
        }

        internal bool RecursiveSearch(Node head, int data)
        {
            if (head == null) return false;

            if (head.data == data) return true;

            return RecursiveSearch(head.next, data);


        }



        // 3 variable 4 steps
        public void Reverse()
        {

            Node first = null;
            var second = tail = head;
            Node third;

            while (second != null)
            {
                third = second.next;
                second.next = first;
                first = second;
                second = third;
            }

            head = first;
        }

        public void RemoveNthNodeFromEnd(int n)
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }

            if (size == 1)
                head = head.next;

            int i = 1;
            Node prev = head;
            while (i < size - n)
            {
                prev = prev.next;
                i++;
            }

            prev.next = prev.next.next;

        }

        // 1 -->2-->2-->1  true
        public bool checkIfLinkedListIsPalindrome_usingAnotherDataStructure()
        {
            List<int> arr = new List<int>();

            Node temp = head;
            while (temp != null)
            {

                temp = temp.next;
                arr.Add(temp.data);
            }

            arr.Reverse();

            Node temp2 = head;

            int i = 0;
            while (temp2 != null)
            {
                if (arr[0] != temp2.data)
                    return false;
                i++;
                temp2 = temp2.next;
            }
            return false;


        }

        public bool checkIfLinkedListIsPalindrome()
        {
            if (head == null || head.next == null) return true;


            // get the middle of the linkedList
            // slow and fast appraoch 

            Node slow = head;      // slow is the mid here 
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse the 2 nd half 

            Node prev = null;
            Node current = slow;
            Node nextNode;
            while (current != null)
            {
                nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            Node right = prev;
            Node left = head;

            while (right != null)
            {
                if (right.data != left.data)
                    return false;
                left = left.next;
                right = right.next;
            }

            return true;

        }


        public void Print()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

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
        //    ll.Print();
        //    ll.RemoveFirst();
        //    ll.RemoveLast();
        //    ll.Print();

        //    var found = ll.RecursiveSearch(head, 7);

        //    ll.Reverse();

        //    //  var isPalindrome = ll.checkIfLinkedListIsPalindrome();
        //}



    }
}
