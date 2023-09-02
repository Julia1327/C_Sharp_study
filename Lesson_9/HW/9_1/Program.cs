﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"



void Rec(int num, int end) {
	if (num > end) {
		return;
	}
	if (num % 2 == 0) {
		Console.WriteLine(num);
	}
	num += 1;
	Rec(num, end);
}

Console.WriteLine("Enter N & M");
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result:");
Rec(N, M);