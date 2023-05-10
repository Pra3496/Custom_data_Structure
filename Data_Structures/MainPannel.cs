using static System.Console;

namespace Data_Structures
{
    internal class MainPannel
    {
        private int selectIndex;
        private string[] option;
        private string prompt = @"
  _____        _           _____ _                   _                       
 |  __ \      | |         / ____| |                 | |                      
 | |  | | __ _| |_ __ _  | (___ | |_ _ __ _   _  ___| |_ _   _ _ __ ___  ___ 
 | |  | |/ _` | __/ _` |  \___ \| __| '__| | | |/ __| __| | | | '__/ _ \/ __|
 | |__| | (_| | || (_| |  ____) | |_| |  | |_| | (__| |_| |_| | | |  __/\__ \
 |_____/ \__,_|\__\__,_| |_____/ \__|_|   \__,_|\___|\__|\__,_|_|  \___||___/
                                                                               ";




        public MainPannel(string[] opt)
        {

            option = opt;
            selectIndex = 0;

        }

        private void DisplayOptions()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            WriteLine(prompt);
            ResetColor();
            WriteLine("\t\t\t----------- OPTIONS -----------\n");

            for (int i = 0; i < option.Length; i++)
            {
                string currentOpt = option[i];
                string prifix;

                if (i == selectIndex)
                {
                    prifix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prifix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                Write("\t\t\t     ");
                WriteLine($"{prifix}<< {currentOpt} >>    ");
                ResetColor();

            }


        }


        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();

                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);

                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectIndex--;
                    if (selectIndex == -1)
                    {
                        selectIndex = option.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectIndex++;
                    if (selectIndex == option.Length)
                    {
                        selectIndex = 0;
                    }
                }


            } while (keyPressed != ConsoleKey.Enter);

            return selectIndex;
        }


    }
}
