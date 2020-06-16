using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Mathematic.GetFib(13));
            //Console.WriteLine(Mathematic.GetFibonachi(13));
            //Console.WriteLine(Mathematic.PowerRanger(3, 1, 9));
            //int[] testArr = Arrays.RemoveSmallest(new int[] { 2, 2, 1, 2, 1 });
            //Console.WriteLine("[{0}]", string.Join(", ", testArr)); 
            TestTree();
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
    }
}
