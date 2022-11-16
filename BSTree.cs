using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTtree
{
    class Node
    {
        public Node leftChild;
        public Node rightChild;
        public int value;
    }

    class BST
    {
        public Node creatBST(int[] postOrder , int start , int end)
        {
            if (start > end) return null;

            Node node = creatNewNode(postOrder[end]);

            int i = findLeftChildIndex(node, end, start, postOrder);

            node.leftChild = creatBST(postOrder, start, i);
            node.rightChild = creatBST(postOrder, i+1, end - 1);

            return node;
        }

        Node creatNewNode(int value)
        {
            Node node = new Node();
            node.rightChild = null;
            node.leftChild = null;
            node.value = value;

            return node;
        }

        public Node insert(Node root , int value)
        {
            if (root == null) return creatNewNode(value);

            if(value < root.value)
            {
                root.leftChild = insert(root.leftChild, value);
            }
            else if(value > root.value)
            {
                root.rightChild = insert(root.rightChild, value);
            }

            return root;
        }

        public bool search(Node root , int value)
        {
            while(root != null)
            {
                if (root.value == value) return true;

                else if (value < root.value) root = root.leftChild;

                else root = root.rightChild;
            }

            return false;
        } 
        
        public Node delete(Node root , int value)
        {
            if (root == null) return root;

            if (value < root.value) root.leftChild = delete(root.leftChild, value);

            else if (value > root.value) root.rightChild = delete(root.rightChild, value);

            else
            {
                // one or no child
                if (root.leftChild == null) return root.rightChild;

                else if (root.rightChild == null) return root.leftChild;

                //two children
                root.value = predecessorReturner(root.leftChild);

                root.leftChild = delete(root.leftChild, root.value);
            }

            return root;
        }

        public void printPreOrder(Node root)
        {
            if (root == null) return;

            Console.Write(root.value + " ");

            printPreOrder(root.leftChild);

            printPreOrder(root.rightChild);
        }

        int predecessorReturner(Node root)
        {
            int max = root.value;
            while(root.rightChild != null)
            {
                max = root.rightChild.value;
                root = root.rightChild;
            }
            return max;
        }

        int findLeftChildIndex(Node node , int end , int start , int[]postOrder)
        {
            int i;
            for (i = end - 1; i >= start; i--)
            {
                if (node.value > postOrder[i]) break;
            }
            return i;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNodes = int.Parse(Console.ReadLine());

            int[] postOrder = new int[numberOfNodes];

            postOrder = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int DeleteNode = int.Parse(Console.ReadLine());

            int inserteNode = int.Parse(Console.ReadLine());

            int searchNode = int.Parse(Console.ReadLine());

            BST bst = new BST();

            Node root =  bst.creatBST(postOrder, 0, postOrder.Length - 1);

            bst.delete(root, DeleteNode);

            bst.insert(root, inserteNode);

            Console.WriteLine(bst.search(root, searchNode));

            bst.printPreOrder(root);

            Console.ReadKey();
        }
    }
}
