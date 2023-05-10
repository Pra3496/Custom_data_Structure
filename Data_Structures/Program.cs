using System;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] opt = {"LINKED LIST","   STACK   ","   QUEUE   ","   Exit    "};

            MainPannel panl = new MainPannel(opt);

            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("\n");
                int option = panl.Run();
                Console.WriteLine("\n***************************************************************************\n");
                switch (option)
                {
                    case 0:

                        MyLinkedList list = new MyLinkedList();

                        list.Run();
                   
                        Console.Write("\nExit From Linked List, press any key.....");
                        Console.ReadKey();
                        Console.WriteLine();  
                        break;

                    case 1:

                        Stacks stack= new Stacks();

                        stack.Run();

                        Console.Write("\nExit From Stack, press any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 2 :

                        Queue queue= new Queue();

                        queue.Run();

                        Console.Write("\nExit From Queue, press any key.....");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;

                    case 3:
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