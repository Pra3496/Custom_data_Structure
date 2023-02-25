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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("\tWEL-COME TO DATA STRUCTURE PROGRAMS");
                Console.WriteLine("*************************************************");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Create linked list");
                Console.WriteLine("2  : Display linked list");
                Console.WriteLine("3  : Add First Node");
                Console.WriteLine("4  : Append Node");
                Console.WriteLine("5  : Add at Position Node");
                Console.WriteLine("6  : Remove First Node");
                Console.WriteLine("7  : Remove Last Node");
                Console.WriteLine("8  : Search Element in linked list");
                Console.WriteLine("9  : Size of linked list");
                Console.WriteLine("10 : Remove-After Node");
                Console.WriteLine("0  : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("********************************************");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------{ ADD NODE }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt= Convert.ToInt32(Console.ReadLine());
                        for(int i = 0;i < iCnt ; i++)
                        {
                            Console.Write("Enter {0} Element : ",i+1);
                            iNo = random.Next(9,100);
                            list.add(iNo);
                        }
                        Console.WriteLine("\n-------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        
                        break;

                    case 2:
                        Console.WriteLine("----------{ DISPLAY NODE }----------\n");
                        Console.Write("Head-");
                        list.display();
                        Console.Write("-NULL");
                        Console.WriteLine("\n------------------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("----------{ ADD-FIRST NODE }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            list.addFirst(iNo);
                        }
                        Console.WriteLine("\n---------------------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("----------{ APPEND NODE }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            Console.Write("Enter {0} Element : ", i + 1);
                            iNo = Convert.ToInt32(Console.ReadLine());
                            list.append(iNo);
                        }

                        Console.WriteLine("\n-----------------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("----------{ ADD-BEETWEEN NODE }----------\n");

                        Console.Write("Enter the Element you want : ");
                        int irNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Element you want to Put {0} after : ",irNo);
                        int iPos = Convert.ToInt32(Console.ReadLine());
                        list.insertAfter(irNo,iPos);

                        Console.WriteLine("\n-----------------------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                
                    case 6:
                        Console.WriteLine("----------{ REMOVE-FIRST NODE }----------\n");

                        list.remove();

                        Console.WriteLine("\n-----------------------------------------");
                        break;

                    case 7:
                        Console.WriteLine("----------{ REMOVE-LAST NODE }----------\n");

                        list.removeLast();

                        Console.WriteLine("\n----------------------------------------");
                       
                        break;
                    case 8:
                        Console.WriteLine("----------{ SEARCH NODE IN LINKED LIST }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iNo = Convert.ToInt32(Console.ReadLine());
                        list.search(iNo);

                        Console.WriteLine("\n--------------------------------------------------");
                      
                        break;
                    case 9:
                        Console.WriteLine("----------{ SIZE OF LINKED LIST }----------\n");

                        list.size();

                        Console.WriteLine("\n-------------------------------------------");
                        break;

          
                    case 10:
                        Console.WriteLine("----------{ REMOVE-AFTER NODE }----------\n");
                        Console.Write("Enter the Element you want to Remove : ");
                        iNo = Convert.ToInt32(Console.ReadLine());
                        list.removeAfter(iNo);

                        Console.WriteLine("\n-------------------------------------------");
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