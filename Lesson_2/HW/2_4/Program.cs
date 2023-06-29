// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
string a = Console.ReadLine()!;
switch (a)
{
    case "1" :
        Console.Write("Понедельник, не выходной");
        break;
    case "2":
        Console.Write("Вторник, не выходной");
        break;
    case "3":
        Console.Write("Среда, не выходной");
        break;
    case "4":
        Console.Write("Четверг, не выходной");
        break;
    case "5":
        Console.Write("Пятница, не выходной");
        break;
    case "6":
        Console.Write("Суббота, выходной!");
        break;
    case "7":
        Console.Write("Воскресенье, выходной!");
        break;
    default:
        Console.Write("Такого дня недели нет");
        break;

}

