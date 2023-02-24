﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structures
{
    public class MyLinkedList
    {
        internal Node head;

        public void add(int data)
        {
            Node node = new Node(data);

            if(this.head == null)
            {
                
                this.head = node;
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
            Console.WriteLine("{0} Inserted into Linked List", data);
        }

        public void addFirst(int data)
        {
            if (this.head == null)
            {
                add(data);
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
            }

            
        }

        internal void display()
        {
            Node temp = this.head;

            if(temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                Console.Write("Head-",temp.data);

                while (temp != null)
                {
                    Console.Write(" {0} -> ", temp.data);
                    temp = temp.next;
                }

                Console.Write("-NULL");
            }
        }
        
    }
}
