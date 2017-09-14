using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._2._Linked_List
{
    // Remove Duplicates in a Linked List.
    // Add items to has table, and if Duplicates exist, delete them
    public class RemoveDups
    {
        public static DNode<T> DeleteDups<T>(DNode<T> head)
        {
            HashSet<T> hashSet = new HashSet<T>();
            DNode<T> temp = head;
            while (temp != null)
            {
                if (!hashSet.Contains(temp.Value))
                {
                    hashSet.Add(temp.Value);
                }
                else // If Hashset already contains value, then remove that item
                {
                    var nextNode = temp.Next;
                    var prevNode = temp.Prev;

                    prevNode.Next = nextNode;
                    nextNode.Prev = prevNode;
                }
                temp = temp.Next;
            }
            return head;
        }
    }
}
