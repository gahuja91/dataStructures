using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> ints = new DoublyLinkedList<int>();
            for(int i = 1; i <= 5; i++)
            {
                ints.AddHead(i);
            }
        }
    }
}
