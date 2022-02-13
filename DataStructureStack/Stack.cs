using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureQueue
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine($"{value} Pushed to Stack");
        }
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine($"{this.top.data} is on top of Stack");
            }
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Nothing to delete Stack is alreadt Empty");
                return;
            }
            else
            {
                Console.WriteLine($"{this.top.data} is Poped Value");
                this.top = this.top.next;
            }
        }
        public void IsEmpty()
        {
            if(this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
