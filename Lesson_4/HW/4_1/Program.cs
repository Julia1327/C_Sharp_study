// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Stepen (int num1, int num2)
{
    int stepen = 1;
    for (int i = 0; i < num2; i++)
    {
        stepen *= num1;
    }
    return stepen;
}

int num_one = int.Parse(Console.ReadLine()!);
int num_two = int.Parse(Console.ReadLine()!);
int stepen = Stepen (num_one, num_two);
Console.WriteLine(stepen);


