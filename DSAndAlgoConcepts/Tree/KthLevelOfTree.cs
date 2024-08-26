using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    internal class KthLevelOfTree
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data)
            {
                this.data = data;
            }
        }


        //static void Main(string[] args)
        //{
        //    var root = new Node(1);
        //    root.left = new Node(2);
        //    root.right = new Node(3);
        //    root.left.left = new Node(4);
        //    root.left.right = new Node(5);
        //    root.right.left = new Node(6);
        //    root.right.right = new Node(7);


        //}
    }
}
