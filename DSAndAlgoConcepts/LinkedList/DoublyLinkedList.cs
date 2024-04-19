using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.LinkedList
{

    internal class DoublyLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public static Node head;
        public static Node tail;
        public static int size;


        //static void Main(string[] args)
        //{

        //    Addfirst(4);
        //    Addfirst(3);
        //    Addfirst(2);
        //    Addfirst(1);
        //    AddLast(5);

        //    Print();
        //    Reverse();
        //    Print();
        //}

        static void Removefirst()
        {
            if (head == null)
            {
                throw new IndexOutOfRangeException("Linked List empty");
            }

            if (head.next == null)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            size--;

        }

        public static void Reverse()
        {
            Node first = null;

            Node second = head;
            Node third;

            while (second != null)
            {
                third = second.next;
                second.next = first;
                second.prev = third;
                first = second;
                second = third;

            }

            head = first;
        }

        static void Addfirst(int data)
        {
            Node node = new Node(data);
            size++;
            if (head == null)
            {
                head = tail = node;
                return;
            }

            node.next = head;
            head.prev = node;
            head = node;
        }

        static void AddLast(int data)
        {
            Node node = new Node(data);
            size++;
            if (head == null)
            {
                head = tail = node;
                return;
            }
            tail.next = node;
            tail = node;
        }


        static void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }

            Console.WriteLine();
        }



    }
}
