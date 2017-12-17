using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (root == null)
            {
                root = newNode;
            }else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }
                    }
                    else {
                        current = current.RightChild;
                        if (current == null) {
                            parent.RightChild = newNode;
                            break;
                        }
                    }
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.add(50);
            tree1.add(40);
            tree1.add(60);
            tree1.add(20);
            tree1.add(45);
            tree1.add(55);
            tree1.add(65);

            Console.ReadLine();
        }
    }
}
