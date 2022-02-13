using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this .head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddInReverse(int data)
        {
            Node newnode = new Node(data);
            if(this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Lenght is " + count);
        }
        public int Search(int data)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == data)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return -1;
        }
        internal void DeleteNodeParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Display();
        }
        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newnode = head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return head;
        }
    }
   
}
