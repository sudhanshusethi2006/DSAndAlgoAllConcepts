using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.LinkedList
{
    internal class CircularLinkedList
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


        //}

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
            head.prev = tail;
            tail.next = head;
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
            node.prev = tail;
            tail = node;
            tail.next = head;
            head.prev = tail;

        }
    }
}
