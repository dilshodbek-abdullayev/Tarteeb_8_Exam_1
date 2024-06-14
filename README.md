>
> # Tarteeb_8_Exam_1
>

## Ushbu dastur  ishga tushganda foydalanuvchi 
![ushbu joyda rasm bor](https://w7.pngwing.com/pngs/898/334/png-transparent-computer-arrow-scrolls-computer-keyboard-arrow-keys-arrow-text-sign-pushbutton.png)
## rasmdagi istalgan ___klaviaturani___ bosganda "*" belgi usha tomon harakatlanadi

- ## Bu dastura ishlatildi
    -   ConsoleKeyInfo keyInfo => Console daga harakatlarni ushlab olish va munosib javob qaytarish uchun
    - Console.SetCursorPosition() => kursorning joylashuvini boshqarish uchun
    - Console.KeyAvailable => dasturda biror tugma bosilgan yoki bosilmaganini ___true___ __or__ ___false___ shaklida qaytaradi
    - Console.ReadKey(true) => bosilgan tugma haqida ma'lumot qaytaradi **true** parametr ma'lumotni ekranga chiqarmaslik uchun **false** esa aksincha ma'lumotni ekranga chiqarish uchun javobgar
## Dasturning umumiy kodi

```BASH
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
```
