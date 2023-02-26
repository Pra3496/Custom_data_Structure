using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Stacks
    {

        public Node head;

        private int iCnt;


        public void push(int data)
        {
            Node newNode = new Node(data);

            if (this.head == null)
            {
                this.head = newNode;
                Console.WriteLine("{0} is added into Stack", newNode.data);
                this.iCnt++;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
                Console.WriteLine("{0} is added into Stack", newNode.data);
                this.iCnt++;
            }


        }

        public void display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.Write("Head-");
                while (temp != null)
                {
                    Console.Write(" {0} -> ", temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("-NULL");
            }
        }


        public void pop()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else if (temp.next == null)
            {
                this.head = null;
                Console.WriteLine("Element is Remove successfully");

            }
            else
            {

                this.head = temp.next;
                Console.WriteLine("First element is Remove successfully");
                this.iCnt--;
            }
        }

        public void peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("{0} is top of Stack", this.head.data);
            }
        }

        public void isEmpty()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack is NOT Empty");
            }
        }

        public void size()
        {
            Console.WriteLine("Stack having {0} Elements. ",this.iCnt);      
        }
    }
}

