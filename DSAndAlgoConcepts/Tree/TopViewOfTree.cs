using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoConcepts.Tree
{
    internal class TopViewOfTree
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

        class Information
        {
            internal Node node;
            internal int horizontaldistance;
            public Information(Node node, int hd)
            {
                this.node = node;
                this.horizontaldistance = hd;
            }
        }


        static void GetTopViewNodes(Node node)
        {
            var queue = new Queue<Information>();

            Dictionary<int, Node> topViewNodes = new Dictionary<int, Node>();

            queue.Enqueue(new Information(node, 0));
            // queue.Enqueue(null);

            while (queue.Count > 0)
            {
                var top = queue.Dequeue();
                if (top == null && queue.Count == 0)
                    break;
                else
                {
                    if (!topViewNodes.ContainsKey(top.horizontaldistance))
                    {
                        topViewNodes.Add(top.horizontaldistance, top.node);
                    }

                    if (top.node.left != null)
                        queue.Enqueue(new Information(top.node.left, top.horizontaldistance - 1));
                    if (top.node.right != null)
                        queue.Enqueue(new Information(top.node.right, top.horizontaldistance + 1));
                }
            }

            topViewNodes.OrderBy(x => x.Key);

            foreach (var node2 in topViewNodes.Values)
            {
                Console.WriteLine(node2.data);
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


        //    GetTopViewNodes(root);
        //}
    }
}
