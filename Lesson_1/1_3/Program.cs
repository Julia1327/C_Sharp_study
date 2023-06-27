// 3. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// // int num1 = -num;
// int count = 0;

// while (count <= num);
// {Console.WriteLine(count);
// count++;
// }


// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = -num;

while (count <= num)
{
    Console.Write(count + " ");
    count++;

}




