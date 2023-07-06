// 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


void Quarters(int num1)
{
    if (num1 == 1)
        Console.WriteLine("x = от 0 до + бесконечности, y = от 0 до + бесконечности");
    else if (num1 == 2)
        Console.WriteLine("x = от - бесконечности до 0, y = от 0 до + бесконечности");
    else if (num1 == 3)
        Console.WriteLine("x = от - бесконечности до 0, y = от - бесконечности до 0");
    else if (num1 == 4)
        Console.WriteLine("x = от 0 до + бесконечности, y = от - бесконечности до 0");
    else
        Console.WriteLine("Введите номер четверти от 1 до 4 включительно");


}

int num = int.Parse(Console.ReadLine()!);
Quarters(num);
