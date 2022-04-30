using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList Is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data); 
            if (head == null)
            {
                head = newNode; 
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }
            Display();
        }
        public int Search(int value)
        {
                Node node = this.head;
                int count = 0;
                while (node != null)
                {

                    if (node.data == value)
                    {
                        return count;
                    }
                    node = node.next;
                    count++;
                }
                return count;
                Console.WriteLine("Search Value Is: " + value);
            
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        internal Node  RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("First Node Is Deleted SuccesFully ");
            return this.head;
        }
    }
}
    

       
