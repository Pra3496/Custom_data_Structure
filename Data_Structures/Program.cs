using System;
using System.Collections.Generic;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyLinkedList list = new MyLinkedList();

            Console.WriteLine("Welcome to data structure programs");
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1 : Create linked list");
                Console.WriteLine("2 : Display linked list");
                Console.WriteLine("3 : Add First linked list");
                Console.WriteLine("4 : Append linked list");
                Console.WriteLine("5 : Add at Position linked list");
                Console.WriteLine("6 : Remove linked list");
                Console.WriteLine("0 : Exit");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.add(56);
                       // list.add(30);
                        list.add(70);
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        list.display();
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        list.addFirst(70);
                        list.addFirst(30);
                        list.addFirst(56);
                        break;
                    case 4:
                        list.append(56);
                        list.append(30);
                        list.append(70);
                        break;
                    case 5:
                        list.addAtPos(333,56);
                        break;
                    case 6:
                        list.remove();
                        break;
                    case 0:
                        flag= false;
                        break;

                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
           



        }
    }
}