// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void rem(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if (num > 10000)
    {
        Console.WriteLine("Третья цифра числа: " + num / 100 % 10);
    }
    else if (num < 100 || num < 1000)
    {
        Console.WriteLine("Третья цифра числа: " + num % 10);
    }
}


Console.Write("Введите число: ");
int numa = int.Parse(Console.ReadLine()!);
rem(numa);


