// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


static int Rec(int num, int end, int sum) {
	if (num > end) {
		return sum;
	}
	sum += num;
	num += 1;
	sum = Rec(num, end, sum);
	return sum;
}

Console.WriteLine("Enter N & M");
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result:");
int sum = Rec(N, M, 0);
Console.WriteLine(sum);