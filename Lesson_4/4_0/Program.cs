// 3 семинар домашка 3 задача!!

// void Squares(int n)
// {
//     double[] nums = new double[n];
//     int index = 0;
//     Console.Write($"{n} — ");

//     while (index < n)
//     {
//         nums[index] = Math.Pow((index + 1), 3);
//         Console.Write($"{nums[index]}, ");
//         index += 1;
//     }
//     Console.WriteLine();
// }

// Squares(int.Parse(Console.ReadLine()!));


// ДЕМОНСТР ЗАДАЧА
// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.


int SunNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;

    return all_sum;

}

int A = int.Parse(Console.ReadLine()!);
int result = SunNum(A);
Console.WriteLine(result);



