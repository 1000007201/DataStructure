using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureQueue
{
    public class Queue
    {
        Node head = null;
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
                head = node;
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
            Console.WriteLine($"{node.data} inserted in Queue");
        }
        public void Display()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void Dequeue()
        {
            if(head == null)
            {
                Console.WriteLine("Queue is already Empty");
                return;
            }
            Console.WriteLine($"{head.data} is Dequeued");
            head = head.next;
        }
        public void Size()
        {
            Node temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size of Queue:"+count);
        }
    }
}
