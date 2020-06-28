using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Edabit
{
    //heep is an implementation of a Binary Search Tree data structure
    public class BinaryTree 
    {
        private TreeNode root;

        // Binary tree constructor
        public BinaryTree() 
        {
            root = null;
        }

        // Binary tree constructor
        public BinaryTree(int value)
        {
            root = new TreeNode(value);
        }

        public void Insert(int value) 
        {
            //if the root is null than we call an InsertNode on the root node
            if (root != null)
            {
                root.InsertNode(value);
            }
            else //if the root is null than we set the root
            {
                root = new TreeNode(value);
            }
        }

        // In order traversal (left -> root -> right)
        public void InOrderTraversal() 
        {
            if (root != null) 
            {
                root.InOrderTraversal();
            }
        }

        // Pre Order traversal (root -> left -> right)
        public void PreOrderTraversal()
        {
            if (root != null)
            {
                root.PreOrderTraversal();
            }
        }

        // Post Order traversal (left -> right -> root)
        public void PostOrderTraversal()
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
        }

        // Method to find a node not a recursive function
        public TreeNode Find(int value) // Complexity O(log n)
        {
            if (root != null)
            {
                return root.Find(value);
            }
            else 
            {
                return null;
            }
        }

        // Method to find a node not a recursive function
        public TreeNode FindRecursive(int value) // Complexity O(log n)
        {
            if (root != null)
            {
                return root.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void remove(int value)
        {
            // Set the current and parent node to a root node
            TreeNode current = root;
            TreeNode parent = root;
            bool isLeftNode = false; // keep track which child of parent will be removed

            // empty tree means nothing to delete so just return from remove method
            if (current == null) 
            {
                return;
            }

            // loop throught until we found the node with currend data equals to a value or until the node is not found
            while (current != null && value != current.Data)
            {
                parent = current; // set parent to current node to be a new parent reference to look for it's children

                // if the value is less than current node data then we look for it's left child
                if (value < current.Data)
                {
                    isLeftNode = true;
                    current = current.Left;
                }
                // if the value is greater than a current node then we look for it's right child
                else 
                {
                    isLeftNode = false;
                    current = current.Right;
                }
            }
            //if the node is not found than return 
            if (current == null) 
            {
                return;
            }

            if (current.Left != null && current.Right != null)
            {
                if (current == root)
                {
                    root = null;
                }
                else
                {
                    // look which child (left, right) of a parent should be deleted
                    if (isLeftNode)
                    {
                        parent.Left = null; // remove reference to left child node
                    }
                    else
                    {
                        parent.Right = null; // remove reference to right child node
                    }
                }
            }
            // if current has only left child than we 
            else if (current.Right == null)
            {
                //if the current node is a root than set a root to a left child node
                if (current == root)
                {
                    root = current.Left;
                }
                // look which child of a parent should be deleted
                else
                {
                    if (isLeftNode)
                    {
                        parent.Left = current.Left;
                    }
                    else 
                    {
                        parent.Left = current.Right;
                    }
                }
            }
            // if current has only right child than we
            else if (current.Left == null) 
            {
                //if the current node is a root than set a root to a right child node
                if (current == root) 
                {
                    root = current.Right;
                }
                // look which child of a parent should be deleted
                else
                {
                    if (isLeftNode)
                    {
                        parent.Left = current.Right;
                    }
                    else 
                    {
                        parent.Left = current.Right;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Node class which implements nodes methods and data
    /// </summary>
    public class TreeNode
    {
        private int data;

        public int Data 
        {
            get { return data; }
        }

        private TreeNode right; //right child

        public TreeNode Right 
        {
            get { return right; }
            set { right = value; }
        }

        private TreeNode left; //left child

        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        // Method that inserts a new node
        public void InsertNode(int value) 
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                    left.InsertNode(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new TreeNode(value);
                }
                else 
                {
                    right.InsertNode(value);
                }
            }
        }

        // Method that checks if the tree contains the value
        public bool Contains(int value) 
        {
            if (data == value)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else 
                {
                    return left.Contains(value);
                }
            }
            else 
            {
                if (right == null)
                {
                    return false;
                }
                else 
                {
                    return right.Contains(value);
                }
            }
        }

        // Method that prints in order traversal
        public void InOrderTraversal() 
        {
            if (left != null) 
            {
                left.InOrderTraversal();
            }
            Console.Write(data + " ");
            if (right != null) 
            {
                right.InOrderTraversal();
            }
        }

        // Method that prints in pre-order traversal
        public void PreOrderTraversal()
        {
            Console.Write(data + " ");
            
            if (left != null) 
            {
                left.PreOrderTraversal();
            }

            if (right != null) 
            {
                right.PreOrderTraversal();
            }
        }

        // Method that prints in post-order traversal
        public void PostOrderTraversal()
        {
            if (left != null)
            {
                left.PostOrderTraversal();
            }

            if (right != null)
            {
                right.PostOrderTraversal();
            }

            Console.Write(data + " ");
        }

        private bool isDeleted; //soft delete variable
        public bool IsDeleted 
        {
            get { return isDeleted; }
        }

        // Node constructor
        public TreeNode(int value) 
        {
            this.data = value;
        }

        // Method which sets soft delete
        public void Delete() 
        {
            isDeleted = true;
        }
        
        // Non recursive method to find a node. Complexity O(log n)
        public TreeNode Find(int value) 
        {
            TreeNode currentNode = this; // this node is a current node

            //loop throught this node and throught the children of this node
            while(currentNode != null) 
            {
                // if the data in the current node is equeal to the value then return a current node
                if (value == currentNode.Data && isDeleted == false) // soft delete check
                {
                    return currentNode;
                }
                // if the value is bigger than a data in the current node than go to the right child
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.right;
                }
                // if the value is smaller than a data in the current node than go to the left child
                else 
                {
                    currentNode = currentNode.left;
                }
            }
            // Node not found
            return null;
        }

        // Recursive method to find a node. Complexity O(log n)
        public TreeNode FindRecursive(int value) 
        {
            // if value equals data than return the node
            if (value == data && isDeleted == false)
            {
                return this;
            }
            // if the value is great than a data in the node then go to the right child
            else if (value >= data && right != null) // check the right node not a null
            {
                return right.FindRecursive(value);
            }
            // if the value is less than a data in the node then go to the left child
            else if (left != null) // check the left node not null
            {
                return left.FindRecursive(value);
            }
            else 
            {
                return null;
            }
        }
    }
}
