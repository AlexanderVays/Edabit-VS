using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    public class Node 
    {
        public int data;
        public Node next;

        public Node(int value) 
        {
            data = value;
            next = null;
        }

        public void AddSorted(int value) 
        {
            if (next == null)
            {
                next = new Node(value);
            }
            else if (value > next.data)
            {
                next.AddSorted(value);
            }
            else 
            {
                Node temp = new Node(value);
                temp.next = this.next;
                this.next = temp;
            }
        }

        // Method that prints a nodes using recursive
        public void Print() 
        {
            Console.Write("|" + data + "|->");
            if (next != null) 
            {
                next.Print();
            }
        }

        // Method that counts items in linked list
        public int Count() 
        {
            if (next == null) 
            {
                return 1;
            }

            return next.Count() + 1;
        }

        // Method that adds a new node to the end
        public void AddToTheEnd(int value) 
        {
            if (next == null) 
            {
                next = new Node(value);
            }
            else 
            {
                next.AddToTheEnd(value);
            }
        }
    }

    public class LinkedList
    {
        public Node headNode;

        public LinkedList() 
        {
            headNode = null;
        }

        public void AddToEnd(int value) 
        {
            if (headNode == null)
            {
                headNode = new Node(value);
            }
            else 
            {
                headNode.AddToTheEnd(value);
            }
        }

        public void AddToBeginning(int value) 
        {
            if (headNode == null)
            {
                headNode = new Node(value);
            }
            else 
            {
                Node temp = new Node(value); // create a new node
                temp.next = headNode; // sets a reference where current headNode will be a next node
                headNode = temp; // sets temp as a headNode
            }
        }

        // Method which adds a new node in sorted order
        public void AddSorted(int value) 
        {
            if (headNode == null)
            {
                headNode = new Node(value);
            }
            else if (value < headNode.data)
            {
                AddToBeginning(value);
            }
            else 
            {
                headNode.AddSorted(value);
            }
        }

        // method that removes a value from a linked list
        public void Remove(int value) 
        {
            if (headNode == null)
            {
                return;
            }
            else if (headNode.data == value) 
            {
                headNode = null;
                return;
            }

            Node previous = headNode;
            Node current = previous.next;

            while (current != null) 
            {
                if (current.data == value)
                {
                    if (current.next == null)
                    {
                        current = null;
                    }
                    else 
                    {
                        previous.next = current.next;
                        return;
                    }
                }
                else 
                {
                    previous = current;
                    current = current.next;
                }
            }
        }

        public int Count() 
        {
            if (headNode == null)
            {
                return 0;
            }
            else 
            {
                return headNode.Count();
            }
        }

        public void Print() 
        {
            if (headNode != null) 
            {
                headNode.Print();
            }
        }
    }
}
