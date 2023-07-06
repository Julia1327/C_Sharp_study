// Формулы вычисления расстояния между двумя точками:
// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости 2D:
// AB = √(xb - xa)2 + (yb - ya)2
// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве 3D:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


// 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) - 5,09
// A (7,-5); B (1,-1) - 7,21

double VectorLenght(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
double result = VectorLenght(x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками = " + result);