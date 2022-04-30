using System;
using LinkedListProblems;

namespace LinkedListProblems
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            //list.AddInReverseOrder(70);
            //list.Display();
            int num = list.Search(56);
            list.InsertAtParticularPosition(num + 1, 30);
            list.Display();
        }
    }
}
