// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// int CheckAndCountNum(int[] arr)
// {
//     int max = arr[0];
//     int min = arr[0];

//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (max < arr[i]) max = arr[i];

//         else if (min > arr[i]) min = arr[i];
//     }

//     return max - min;
// }


// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine(arr[i]);
//     }
// }

// int[] MassNums(int size, int from, int to)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(from, to + 1);
//     }
//     return arr;
// }

// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);
// int c = int.Parse(Console.ReadLine()!);

// int[] mass = MassNums(a, b, c);
// PrintArray(mass);
// System.Console.WriteLine(CheckAndCountNum(mass));





double FindMaxAndMinDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];

        else if (min > arr[i]) min = arr[i];
    }

    return max - min;
}


void PrintArray(double[] arr)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        int val = new Random().Next(from, to + 1);
        //System.Console.WriteLine("val:" + val);
        double val2 = Convert.ToDouble(val);
        
        val2 = val2 / 10;
        //System.Console.WriteLine("val2:" + val2);
        arr[i] = val2;
    }
    return arr;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(a, b, c);
PrintArray(mass);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива:" + FindMaxAndMinDiff(mass));



