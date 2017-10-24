using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX008_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            // vkládání
            list.AddLast(5);   list.AddLast(4);    list.AddLast(23);
            list.AddLast(1);   list.AddLast(2);    list.AddLast(5);
            LinkedListNode<int> node = new LinkedListNode<int>(7);
            list.AddLast(node);
            list.AddBefore(node, 5);

            // mazání
            list.Remove(node);
            list.Remove(5);

        }
    }
}
