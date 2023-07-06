// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


void Crat(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        Console.WriteLine("Числа кратны");
    else
    {
        Console.WriteLine("Числа не кратны");
    }
}


int numa = int.Parse(Console.ReadLine()!);
Crat(numa);

