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

        static Node head;
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


        public void Reverse()
        {

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

        static void Main(string[] args)
        {
            LinkedListClass ll = new LinkedListClass();
            ll.AddFirst(1);
            ll.AddFirst(2);
            ll.AddFirst(3);
            ll.AddLast(4);
            ll.AddLast(5);
            ll.AddLast(6);
            ll.AddAtIndex(4, 7);
            ll.Print();
            ll.RemoveFirst();
            ll.RemoveLast();
            ll.Print();

            var found = ll.RecursiveSearch(head, 7);
        }



    }
}
