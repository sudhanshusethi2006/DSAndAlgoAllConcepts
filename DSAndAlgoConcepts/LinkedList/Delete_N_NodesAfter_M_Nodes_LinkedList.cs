using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.LinkedList
{
    public class Delete_N_NodesAfter_M_Nodes_LinkedList
    {

        static LinkedListClass.Node head;

        //static void Main(string[] args)
        //{
        //    LinkedListClass ll = new LinkedListClass();
        //    ll.AddFirst(8);
        //    ll.AddLast(1);

        //    ll.AddLast(4);
        //    //ll.AddLast(5);
        //    //ll.AddLast(6);
        //    //ll.AddLast(7);
        //    //ll.AddLast(8);
        //    //ll.AddLast(9);
        //    ll.AddLast(10);
        //    int M = 2;
        //    int N = 1;

        //    head = LinkedListClass.head;
        //    Delete_N_NodesAfter_M_Nodes(N, M);

        //}

        static void Delete_N_NodesAfter_M_Nodes(int N, int M)
        {
            var temp = head;
            var prev = head;
            while (temp != null)
            {
                for (int i = 0; i < M; i++)
                {
                    prev = temp;
                    if (temp == null) break;
                    temp = temp.next;
                }
                for (int i = 0; i < N; i++)
                {
                    if (temp == null) break;
                    temp = temp.next;
                }
                if (prev != null)
                    prev.next = temp;
            }

        }
    }
}
