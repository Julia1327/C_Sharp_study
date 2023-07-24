// 2 задача варианты

// int SunNums_2(int num)
// {
//     int n_sum = 0;

//     for (; num !=0; num/=10)
//     n_sum += num % 10;

//     return n_sum;

// }

// int num_2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SunNums_2(num_2));


// --------------------------- 3 вариант
// // https://shwanoff.ru/char-c-sharp/


// double DigitSum(int num)
// {
// string n = num.ToString();
// int length = n.Length;
// double sum = 0;

// for (int i = 0; i < length; i++)
// {
// double m = char.GetNumericValue(n[i]);
// sum += m;
// }

// return sum;
// }

// int n = int.Parse(Console.ReadLine()!); ;

// Console.WriteLine(DigitSum(n));


// 3 задача дз

// void Print(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]}");
//     Console.WriteLine();
// }

// int[] EightMass(int size, int from, int to)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(from, to + 1);
//     return arr;
// }

// int num = int.Parse(Console.ReadLine()!);
// int start = int.Parse(Console.ReadLine()!);
// int stop = int.Parse(Console.ReadLine()!);

// int[] mass = EightMass(num, start, stop);
// Print(mass);


// ДЕМОНСТР ЗАДАЧА 5 СЕМИНАР

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);