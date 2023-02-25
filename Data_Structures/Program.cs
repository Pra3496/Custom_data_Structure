using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyLinkedList list = new MyLinkedList();

            Random random = new Random();
           
            int iNo,iCnt = 0;

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
                Console.WriteLine("6 : RemoveLast linked list");
                Console.WriteLine("7 : RemoveLast linked list");
               
                Console.WriteLine("0 : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.Write("Enter the Element you want : ");
                        iCnt= Convert.ToInt32(Console.ReadLine());
                        for(int i = 0;i < iCnt ; i++)
                        {
                            Console.Write("Enter {0} Element : ",i+1);
                            iNo = random.Next(9,100);
                            list.add(iNo);
                        }

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("\n");
                        Console.Write("Head-");
                        list.display();
                        Console.Write("-NULL");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            list.addFirst(iNo);
                        }
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 4:

                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            list.append(iNo);
                        }
                        
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Enter the Element you want : ");
                        int irNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Element you want : ");
                        int iPos = Convert.ToInt32(Console.ReadLine());
                        list.insertAfter(irNo,iPos);

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                
                    case 6:
                        list.remove();
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 7:
                        list.removeLast();
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
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