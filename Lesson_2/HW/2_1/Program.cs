// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int TakeNum(int num)
{
    if (num > 999 | num < 100)
    {
        Console.Write("Вы ввели не трехзначное число: ");
        return num;
    }

    else
    {
        Console.Write("Вторая цифра числа: ");
        return num / 10 % 10;

    }
}

Console.Write("Введите трехзначное число: ");
int numA = int.Parse(Console.ReadLine()!);
int result = TakeNum(numA);
Console.Write(result);



