using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._2._Linked_List
{
    public class Cycle
    {
        // Runner technique, to have 2 pointers incrementing at different speeds
        public static bool HasCycle<T>(Node<T> head)
        {
            // Start them at different points, slow at node 1 and fast at node 2
            Node<T> fast = head.Next;
            Node<T> slow = head;

            while (fast != null && slow != null)
            {
                if (fast == slow)
                {
                    return true;
                }

                fast = fast?.Next?.Next;
                slow = slow?.Next;
            }
            return false;
        }
    }
}
