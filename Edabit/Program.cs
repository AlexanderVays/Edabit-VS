using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 1, 0, 0, 0 };
            Console.WriteLine(StackQueue.Fish(A, B)); */
            Dictionary.GetPopulated();
            Dictionary.GetSortedByValue(4);
        }

        public static void TestTree() 
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            var node = binaryTree.FindRecursive(32);
            if (node != null)
            {
                Console.WriteLine(node.Data);
            }
            else 
            {
                Console.WriteLine("Nothing found");
            }
        }

        public static void TestLinkedList() 
        {
            LinkedList myList = new LinkedList();
            myList.AddSorted(9);
            myList.AddSorted(5);
            myList.AddSorted(11);
            myList.AddSorted(4);
            myList.AddSorted(3);
            myList.AddSorted(6);
            myList.Print();
            Console.WriteLine($"\r\nThe number of items in the list is {myList.Count()}");
        }
    }
}
