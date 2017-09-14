using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._2._Linked_List
{
    public class DoublyLinkedList
    {
        public static int Count = 0;

        // Add to Start
        public static DNode<T> AddToStart<T>(T data, DNode<T> headNode)
        {
            DNode<T> node = new DNode<T>(data);

            if (headNode == null)
            {
                headNode = node;
            }
            else
            {
                node.Next = headNode;
                headNode.Prev = node;
                headNode = node;
            }
            Count++;
            return headNode;
        }
        // Add to End
        public static DNode<T> AddToEnd<T>(T data, DNode<T> headNode)
        {
            DNode<T> node = new DNode<T>(data);

            if (headNode == null)
            {
                headNode = node;
            }
            else
            {
                DNode<T> temp = headNode;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                node.Prev = temp;
            }
            Count++;
            return headNode;
        }
        // Print all Nodes
        public static List<T> PrintNodes<T>(DNode<T> headNode)
        {
            DNode<T> temp = headNode;
            List<T> list = new List<T>();
            while (temp != null)
            {
                list.Add(temp.Value);
                temp = temp.Next;

            }
            return list;
        }

        // Delete a Node by value
        public static DNode<T> DeleteNode<T>(T data, DNode<T> headNode)
        {
            if (headNode == null)
            {
                return null;
            }
            else
            {
                DNode<T> temp = headNode;
                while (!temp.Value.Equals(data))
                {
                    temp = temp.Next;
                }
                var prevNode = temp.Prev;
                var nextNode = temp.Next;

                prevNode.Next = nextNode;
                nextNode.Prev = prevNode;
            }
            Count--;
            return headNode;
        }

        // Add After 
        public static DNode<T> AddAfterNode<T>(T data, T afterData, DNode<T> headNode)
        {
            if (headNode == null)
            {
                return null;
            }
            else
            {
                DNode<T> node = new DNode<T>(data);
                DNode<T> temp = headNode;
                while (!temp.Value.Equals(afterData))
                {
                    temp = temp.Next;
                }
                var prevNode = temp.Prev;
                var nextNode = temp.Next;

                temp.Next = node;
                node.Prev = temp;
                node.Next = nextNode;
            }
            Count++;
            return headNode;
        }
    }

    public class DNode<T>
    {
        public T Value { get; set; }
        public DNode<T> Prev { get; set; }
        public DNode<T> Next { get; set; }

        public DNode(T value)
        {
            this.Value = value;
            this.Prev = null;
            this.Next = null;
        }
    }
}
