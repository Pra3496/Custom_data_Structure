using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stacks stack= new Stacks();

            Random random = new Random();
           
            int iNo,iCnt = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("\tWEL-COME TO DATA STRUCTURE STACKS");
                Console.WriteLine("*************************************************");
                Console.WriteLine("\t----------OPTIONS----------\n");
                Console.WriteLine("1  : Create stack");
                Console.WriteLine("2  : Display Stack");
                Console.WriteLine("0  : Exit\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("********************************************");
                switch (option)
                {
                    case 1:
                       
                        Console.WriteLine("----------{ ADD NODE }----------\n");
                        Console.Write("Enter the Element you want : ");
                        iCnt = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < iCnt; i++)
                        {
                            iNo = random.Next(9, 99);
                            Console.Write("\nEnter {0} Element : ", i + 1);
                            stack.push(iNo);
                        }
                        Console.WriteLine("\n--------------------------------");

                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();  
                        break;

                    case 2:
                        Console.WriteLine("----------{ DISPLAY NODE }----------\n");
                        
                        stack.display();
                        
                        Console.WriteLine("\n-----------------------------------");
                        Console.Write("\npress any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    
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