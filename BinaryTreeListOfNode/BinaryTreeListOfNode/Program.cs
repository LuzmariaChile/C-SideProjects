using System;
// Hi Luz Maria
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeListOfNode
{
    class TreeNode
    {
        public TreeNode leftChild;
        public TreeNode rightChild;
        public int value;

        public TreeNode(int newValue)
        {
            this.value = newValue;
            this.leftChild = null;
            this.rightChild = null;
        }
    }

    class BinaryTree
    {
        public TreeNode root;
        public BinaryTree()
        {
            root = null;
        }

        private void AddValue(ref TreeNode node, int newValue) 
        {
            if ( node == null)
            {
                 node = new TreeNode(newValue);
                return;
            }
            if (node.value >= newValue)
            {
                AddValue(ref node.leftChild, newValue);
                return;
            }
            AddValue(ref node.rightChild, newValue);
        }


        public void AddValue(int newValue)
        {
            AddValue(ref this.root, newValue);
        } 
        private void Print(TreeNode n)
        {
            if (n == null) { return; }
            Console.Write("[" + n.value.ToString());
            Print(n.leftChild);
//            Console.Write(" ");
            Print(n.rightChild);
            Console.Write("]");
        }

        public void Print()
        {
            Print(this.root);
            Console.WriteLine();
        }

        private int CountNodes(TreeNode n)
        {
            var c = 0;
            if (n == null) { return 0; }
            else
            {
                c = 1 + CountNodes(n.leftChild) + CountNodes(n.rightChild);
                return c;
            }
        }

        public int CountNodes()
        {
            return CountNodes(this.root);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var myTree = new BinaryTree();
            myTree.AddValue(10);
            myTree.AddValue(15);
            myTree.AddValue(5);
            myTree.AddValue(11);
            myTree.AddValue(7);
            myTree.AddValue(3);
            myTree.AddValue(20);
            myTree.AddValue(22);
            myTree.AddValue(2);
            myTree.AddValue(-1);
            myTree.AddValue(-10);



            myTree.Print();
            var NumberOfNodes = myTree.CountNodes();
            Console.WriteLine("number of nodes = "+NumberOfNodes);
            Console.ReadKey();
        }
    }
}
