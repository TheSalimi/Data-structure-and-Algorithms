using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingWithChains
{
    class Program
    {
        static int m = 0;
        public static Linkedlist[] array;
        static int x = 263;
        const long p = 1000000007;

        static void Main(string[] args)
        {
            List<string> answer = new List<string>();
            m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            array = new Linkedlist[m];

            for (int i = 0; i < m; i++) array[i] = new Linkedlist();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                switch (arr[0].ToLower())
                {
                    case "add":
                        {
                            int num = hash(arr[1]);
                            if (!array[num].find(arr[1], array[num])) array[num].add(arr[1]);
                            break;
                        }
                    case "del":
                        {
                            int num = hash(arr[1]);
                            if (array[num].find(arr[1], array[num]))
                                array[num].delete(arr[1] , array[num], null);
                            break;
                        }
                    case "find":
                        {
                            int num = hash(arr[1]);
                            if (array[num].find(arr[1], array[num])) answer.Add("yes");
                            else answer.Add("no");
                            break;
                        }
                    case "check":
                        {
                            string answerStr = "";
                            int f = int.Parse(arr[1]) ;
                            Node temp = array[f].Head;
                            while (temp != null)
                            {
                                answerStr += (temp.value+" ");
                                temp = temp.rightNode;
                            }
                            answer.Add(answerStr);
                            break;
                        }
                }
            }
            foreach (string i in answer) Console.WriteLine(i);

            Console.ReadKey();
        }

        public static int hash(string text)
        {
            long sum = 0;
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(text);
            for (int i = 0; i < text.Length; i++)
                sum = (sum + (ASCIIvalues[i]* pow(i)) % p) % p;
            
            return Convert.ToInt32(sum % m);
        }

        static long pow(int i)
        {
            if (i == 0) return 1;
            long m = x;
            if(i!=1) for (int j = 1; j < i; j++) m = (m * x) % p;
            return m;
        }

        public static bool IsInLinkedList(string text , Node root)
        {
            if (root.value == null) return false;
            else if (root.value == text) return true;

            return IsInLinkedList(text, root.rightNode);
        }
    }

    class Linkedlist
    {
        public Node Head;

        public void add(string text)
        {
            Node node = new Node(text);
            node.rightNode = Head;
            Head = node;

        }
        public void delete(string text, Linkedlist linkedlist , Node left)
        {
            Node headTemp = linkedlist.Head;
            Node prev = null;

            if (headTemp != null && headTemp.value == text)
            {
                linkedlist.Head = headTemp.rightNode;
                return;
            }

            while(headTemp!=null && headTemp.value != text)
            {
                prev = headTemp;
                headTemp = headTemp.rightNode;
            }

            if (headTemp == null) return;

            prev.rightNode = headTemp.rightNode;
        }
        public bool find(string text , Linkedlist linkedlist)
        {
            Node temp = linkedlist.Head;
            if (temp == null) return false;

            while(text != temp.value)
            {
                if (temp.rightNode == null) return false;
                temp = temp.rightNode;
            }
            return true;
        }
    }

    class Node
    {
        public string value;
        public Node rightNode;

        public Node(string value) { this.value = value; }
    }
}
