using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traverseBST
{
    class Node
    {
        public char value;
        public int ID;

        public Node leftChild;
        public Node rightChild;

        public Node(char value , int ID) { this.value = value; this.ID = ID; }
        public Node(int id)
        {
            value = Program.findValue(Program.ID_Value, id);
            ID = id;
        }
    }

    class BST
    {
        public Node creatNewNode(int ID)
        {
            Node node = new Node(Program.findValue(Program.ID_Value , ID) , ID);
            node.rightChild = null;
            node.leftChild = null;

            return node;
        }

        public void insert(Node root, int id)
        {
            if (id < root.ID)
            {
                if (root.leftChild == null) root.leftChild = new Node(id);
                else insert(root.leftChild, id);
            }
            else if (id > root.ID)
            {
                if (root.rightChild == null) root.rightChild = new Node(id);
                else insert(root.rightChild, id);            }
        }

        public void makeTree(Node root , int[,] ID_ID)
        {
            for (int i = 0; i < ID_ID.GetLength(0) ; i++)
            {
                 insert(root, ID_ID[i , 1]);
            }
        }
    }

    class Traverse
    {
        public static void printInOrder(Node node)
        {
            if (node == null) return;
            printInOrder(node.leftChild);
            Console.Write(node.value);
            printInOrder(node.rightChild);
        }

        public static void printPreOrder(Node node)
        {
            if (node == null) return;

            Console.Write(node.value);
            printPreOrder(node.leftChild);
            printPreOrder(node.rightChild);
        }

        public static void printPostOrder(Node node, ref string answer)
        {
            if (node == null) return;

            printPostOrder(node.leftChild, ref answer);
            printPostOrder(node.rightChild, ref answer);
            answer += node.value;
        }

        public static double calculatePostfixByStack(string postfixExpression)
        {
            Stack<double> stack = new Stack<double>();
            int size = postfixExpression.Length;

            for (int i = 0; i < size; i++)
            {
                if (postfixExpression[i] >= '0' && postfixExpression[i] <= '9') stack.Push(postfixExpression[i] - '0');
                else
                {
                    double a = stack.Pop();
                    double b = stack.Pop();

                    switch (postfixExpression[i])
                    {
                        case '+':
                            stack.Push(a + b);
                            break;
                        case '-':
                            stack.Push(b - a);
                            break;
                        case '*':
                            stack.Push(b * a);
                            break;
                        case '/':
                            stack.Push(b / a);
                            break;
                        case '^':
                            stack.Push(Math.Pow(b, a));
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }

    class Program
    {
        public static string[,] ID_Value;
        public static int[,] ID_ID;

        static private string [,] getID_Value(int numberOfNodes)
        {
            string[,] array = new string[numberOfNodes, 2];

            for (int i = 0; i < numberOfNodes; i++)
            {
                string[] tempArray = new string[2];
                tempArray = Console.ReadLine().Split(' ');
                array[i, 0] = tempArray[0];
                array[i, 1] = tempArray[1];
            }

            return array;
        }

        static private int[,] getID_ID(int numberOfNodes)
        {
            int[,] array = new int[numberOfNodes - 1, 2];

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                string[] tempArray = new string[2];
                tempArray = Console.ReadLine().Split(' ');
                array[i, 0] = int.Parse(tempArray[0]);
                array[i, 1] = int.Parse(tempArray[1]);
            }

            return array;
        }

        static public char findValue(string[,] array, int id)
        {
            char value = ' ';
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (int.Parse(array[i, 0]) == id) { value = Char.Parse(array[i, 1]); return value; }
            }
            return value;
        }

        static void Main()
        {
            int numberOfNodes = int.Parse(Console.ReadLine());

            ID_Value = new string[numberOfNodes, 2];
            ID_ID = new int[numberOfNodes, 2];

            ID_Value = getID_Value(numberOfNodes);
            int rootID = int.Parse(Console.ReadLine());
            ID_ID = getID_ID(numberOfNodes);

            BST bst = new BST();
            Node root = new Node(rootID);

            bst.makeTree(root, ID_ID);

            string postOrder = "" ;
            Traverse.printPostOrder(root, ref postOrder);
            Console.WriteLine(postOrder);
            Traverse.printInOrder(root);
            Console.WriteLine();
            Traverse.printPreOrder(root);
            Console.WriteLine();
            string answer = Traverse.calculatePostfixByStack(postOrder).ToString("0.00");
            Console.WriteLine(answer);

            Console.ReadKey();
        }

    }
}
