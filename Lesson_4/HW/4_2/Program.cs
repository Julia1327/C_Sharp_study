﻿// Задача 2: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum (int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num%10;
        num = num /10;
    }
return result;
}

int number = int.Parse(Console.ReadLine()!);
int st = Sum (number);
Console.WriteLine(st);
