﻿// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


int SunNum(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
        all_sum = all_sum*i;

    return all_sum;

}

int A = int.Parse(Console.ReadLine()!);
int result = SunNum(A);
Console.WriteLine(result);



