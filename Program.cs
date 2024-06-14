using System;
using System.Threading;

class Program
{
    static void Main()
    {
        #region
        int koordinateB = Console.WindowHeight / 2;
        int koordinateA = Console.WindowWidth / 2;

        ConsoleKeyInfo keyInfo;
        Console.CursorVisible = false;

        while(true){
            Console.Clear();
            Console.SetCursorPosition(koordinateA,koordinateB);
            Console.Write("*");

            if(Console.KeyAvailable){
                keyInfo = Console.ReadKey(true);

                switch(keyInfo.Key){
                    case ConsoleKey.UpArrow:
                        if(koordinateB > 0) koordinateB--;
                            break;
                    case ConsoleKey.RightArrow:
                        if(koordinateA < Console.WindowWidth - 1) koordinateA++;
                            break;
                    case ConsoleKey.DownArrow:
                        if(koordinateB < Console.WindowHeight - 1)koordinateB++;
                            break;
                    case ConsoleKey.LeftArrow:
                        if(koordinateA > 0)koordinateA--;
                            break;
                }
            }
            Thread.Sleep(50);
        }
        #endregion

        // string inputChar = Console.ReadLine();
        // int valueChar = Convert.ToInt32(inputChar);
        // Console.Write($"{inputChar} ASCII value is {valueChar}");

    }
}
