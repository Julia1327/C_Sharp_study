// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

// 14212 -> нет

// 12821 -> да

// 23432 -> да



try
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int a = number % 10;
    int b = (number % 100 - a) / 10;
    int c = (number % 1000 - b) / 100;
    int d = (number % 10000 - c) / 1000;
    int e = (number % 100000 - d) / 10000;

    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Нужно ввести пятизначное число. Повторите попытку, введите пятизначное число.");
    }

  else if (a == e & b == d)
    {
        Console.WriteLine("Число палиндром");
    }

    
    else
    {
        Console.WriteLine("Число не палиндром");
    }

}

catch
{
    Console.WriteLine("Нужно ввести пятизначное число. Повторите попытку, введите пятизначное число.");
}
