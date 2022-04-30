using System;
using LinkedListProblems;

using System;

namespace LinkedListProblem
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Problem Statements");
            bool end = true;
            Console.WriteLine("Enter Option\n1.Add The Data \n2.Reverse The Data \n3.Insert The Data \n4.Remove First No0de \n5. Delete The Last Node \n6.Search The Element \n7. End Of Program ");
            while (end)
            {
                LinkedList list = new LinkedList();
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(70);
                        list.Add(30);
                        list.Add(56);
                        list.Display();
                        break;
                    case 3:
                        list.Add(56);
                        list.Add(70);
                        int num = list.Search(56);
                        list.InsertAtParticularPosition(num + 1, 30);
                        list.Display();
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveFirstNode();
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeleteLastNode();
                        list.Display();
                        break;
                    case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Search(30);
                        list.Display();
                        break;
                    case 7:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;
                }
            }
        }
    }
}