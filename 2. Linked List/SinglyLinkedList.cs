using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CTCI._2._Linked_List
{
    public class SinglyLinkedList
    {
        public static int Count = 0;

        // Add to Start
        public static Node<T> AddToStart<T>(T data, Node<T> headNode)
        {
            Node<T> node = new Node<T>(data);

            if (headNode == null)
            {
                headNode = node;
            }
            else
            {
                node.Next = headNode;
                headNode = node;
            }
            Count++;
            return headNode;
        }
        // Add to End
        public static Node<T> AddToEnd<T>(T data, Node<T> headNode)
        {
            Node<T> node = new Node<T>(data);

            if (headNode == null)
            {
                headNode = node;
            }
            else
            {
                Node<T> temp = headNode;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Count++;
            return headNode;
        }
        // Print all Nodes
        public static List<T> PrintNodes<T>(Node<T> headNode)
        {
            Node<T> temp = headNode;
            List<T> list = new List<T>();
            while (temp != null)
            {
                list.Add(temp.Value);
                temp = temp.Next;

            }
            return list;
        }

        // Delete a Node by value
        public static Node<T> DeleteNode<T>(T data, Node<T> headNode)
        {
            if (headNode == null)
            {
                return null;
            }
            else
            {
                Node<T> temp = headNode;
                while (!temp.Next.Value.Equals(data))
                {
                    temp = temp.Next;
                }
                var nextNextNode = temp.Next.Next;
                temp.Next = nextNextNode;
            }
            Count--;
            return headNode;
        }

        // Add After 
        public static Node<T> AddAfterNode<T>(T data, T afterData, Node<T> headNode)
        {
            if (headNode == null)
            {
                return null;
            }
            else
            {
                Node<T> node = new Node<T>(data);
                Node<T> temp = headNode;
                while (!temp.Value.Equals(afterData))
                {
                    temp = temp.Next;
                }
                var nextNode = temp.Next;
                temp.Next = node;
                node.Next = nextNode;
            }
            Count++;
            return headNode;
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
