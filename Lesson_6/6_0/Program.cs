// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.




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
double n_max = arr[0];
double n_min = arr[0];
for (int i =1; i<arr.Length;i++)
{
    if (n_max<arr[i])
    n_max = arr[i];
    else if (n_min>arr[i])
    n_min = arr[i];
}

}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (to - from + from, 2));
    }
    return arr;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(a, b, c);
PrintArray(mass);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива:" + FindMaxAndMinDiff(mass));
