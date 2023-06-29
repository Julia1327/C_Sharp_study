
// 2 Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// 78 - 8
// 12 - 2
// 85 - 8


// int num = new Random().Next(10, 100);
// Console.WriteLine($"Сгенерировано случайное двузначное число: {num}");
// int res1 = num % 10;
// int res2 = num / 10;

// if (res1 < res2)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {res2}");
// }

// else if (res1 == res2)
// {
//     Console.WriteLine($"Числа равны");
// }

// else
// {
//     Console.WriteLine($"Наибольшая цифра числа: {res1}");
// }

// 2 ВАРИАНТ

int Max(int num)
{
    if (num / 10 > num % 10)
        return num / 10;

    return num % 10;

}
int RNum = new Random().Next(10, 100);
Console.WriteLine($"Было сгенерировано случайное двузначное число: {RNum}");
int result = Max(RNum);
Console.WriteLine($"Наибольшая цифра числа: {result} ");


