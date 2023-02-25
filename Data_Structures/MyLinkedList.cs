using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structures
{
    public class MyLinkedList
    {
        public Node head;

        private int iCnt;

        public void add(int data)
        {
            Node node = new Node(data);

            if(this.head == null)
            {
                
                this.head = node;
                this.iCnt++;
            }
            else
            {
                Node temp = head;

                while(temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                this.iCnt++;

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
                this.iCnt++;
            }

            
        }

        public void append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
                this.iCnt++;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
                this.iCnt++;
            }
        }

        public void insertAfter(int data, int iPos)
        {

            Node newNode = new Node(data);
            

            if (this.head == null)
            {
                this.head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
                this.iCnt++;
            }
            else
            {
                Node temp = this.head;
               
                while(temp.next != null)
                {
                    if(temp.data == iPos)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        this.iCnt++;
                        break;
                    }
                    temp = temp.next;
                }

                if(temp.next == null)
                {
                    Console.WriteLine("\nGiven {0} Node is Not Present in Linked List",iPos);
                }
                else
                {
                    Console.WriteLine("{0} is added Between {1} and {2} linked list", newNode.data, temp.data, (newNode.next).data);
                    
                }
            }
        }


        public void remove()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
                
            }
            else
            {
                this.head = (this.head).next;
                Console.WriteLine("First element is deleted successfully");
                this.iCnt--;
            }

        }


        public void removeLast()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else if(temp.next == null)
            {
                this.head = null;

            }
            else
            { 
                while ((temp.next).next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Last element is deleted successfully");
                this.iCnt--;
            }
        }

        public void removeAfter(int iPos)
        {

            if (this.head == null)
            {
               
                Console.WriteLine("Linked List is Empty");
               
            }
            else
            {
                Node temp = this.head;

                while (temp.next != null)
                {
                    if ((temp.next).data == iPos)
                    {

                        temp.next = (temp.next).next;
                        
                        this.iCnt--;
                        break;
                    }
                    temp = temp.next;
                }

                if (temp.next == null)
                {
                    Console.WriteLine("\nGiven {0} Node is Not Present in Linked List", iPos);
                }
                else
                {
                    Console.WriteLine("Node Deleted Successfully");

                }
            }
        }



        public void search(int iValue)
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                int iCnt = 0;
                Console.Write("Head-", temp.data);

                while (temp != null)
                {
                    iCnt++;
                    if (temp.data == iValue)
                    {
                        Console.WriteLine(" The value {0} Found at {1} Position.", temp.data, iCnt);
                        break;
                    }

                    temp = temp.next;
                }

                if (temp == null)
                {
                    Console.WriteLine("{0} is not found in linked list", iValue);
                }

            }
        }


        public void display()
        {
            Node temp = this.head;

            if(temp == null)
            {
                Console.WriteLine("Linked list is Empty");
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

        public void size()
        {
            Console.WriteLine("Linked List having {0} Nodes ",this.iCnt);
        }

        public void sort()
        {
            int trNd = 0;
            Node temp = this.head;
            Node fwrd = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    fwrd= temp.next;
                    while(fwrd != null)
                    {
                        if((temp.data)>(fwrd.data))
                        {       
                            trNd = temp.data;

                            temp.data = fwrd.data;

                            fwrd.data = trNd;
                        }
                        


                        fwrd = fwrd.next;
                    }

                    temp = temp.next;
                }
            }
        }



    }
}
