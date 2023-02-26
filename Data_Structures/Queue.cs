using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Queue
    {
        public Node head;

        private int iCnt;

        public void enqueue(int data)
        {
            Node newNode = new Node(data);

            if (this.head == null)
            {
                this.head = newNode;
                Console.WriteLine("{0} is added into Queue", newNode.data);
                this.iCnt++;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
                Console.WriteLine("{0} is added into Queue", newNode.data);
                this.iCnt++;
            }


        }

        public void display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
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


        public void dequeue()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else if (temp.next == null)
            {
                this.head = null;
                Console.WriteLine("Dequeue is Successfully Done ");
                iCnt--;
            }
            else
            {
                while ((temp.next).next != null)
                {
                    temp = temp.next;
                }

                temp.next = null;
                Console.WriteLine("Dequeue is Successfully Done ");
                iCnt--;
            }
        }

        public void isEmpty()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Queue is NOT Empty");
            }
        }

        public void size()
        {
            Console.WriteLine("Queue having {0} Elements. ", this.iCnt);
        }



    }
}
