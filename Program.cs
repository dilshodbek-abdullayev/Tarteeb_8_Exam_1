using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int y = Console.WindowHeight / 2;
        int x = Console.WindowWidth / 2;

        ConsoleKeyInfo keyInfo;
        Console.CursorVisible = false;

        while(true){
            Console.Clear();
            Console.SetCursorPosition(x,y);
            Console.Write("*");

            if(Console.KeyAvailable){
                keyInfo = Console.ReadKey(true);

                switch(keyInfo.Key){
                    case ConsoleKey.UpArrow:
                        if(y > 0) y--;
                            break;
                    case ConsoleKey.RightArrow:
                        if(x < Console.WindowWidth - 1) x++;
                            break;
                    case ConsoleKey.DownArrow:
                        if(y < Console.WindowHeight - 1)y++;
                            break;
                    case ConsoleKey.LeftArrow:
                        if(x > 0)x--;
                            break;
                }
            }
            Thread.Sleep(50);
        }

    }
}
