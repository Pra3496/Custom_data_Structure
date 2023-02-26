﻿using System;
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
    }
}
