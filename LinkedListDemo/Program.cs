using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            //.Find finds and returns the linked list "node" for the input(string)
            LinkedListNode<string> nixon = presidents.Find("Richard Nixon");

            //LinkedListNode<T> encapsulates all the info about 
            //previous and next element in a linked list
            presidents.AddAfter(nixon, "Gerald Ford");

            //searches the entire list and removes
            //can be replaced with .RemoveFirst() in this case
            presidents.Remove("JFK");

            //also return the created linked list node
            //eg: "LinkedListNode<string> Jk =...."
            presidents.AddFirst("John F Kennedy");

            foreach (string president in presidents)
                Console.WriteLine(president);
        }
    }
}
