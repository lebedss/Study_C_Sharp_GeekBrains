// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние между точкам A и B --> d = квадратный корень из  [(x2-x1)^2+ (y2-y1)^2+ (z2-z1)^2], где A(x1, y1, z1) и B(x2, y2, z2)  две точки в 3D пространстве.
using static System.Console;
// Задача 21
Clear();

// WriteLine("Введите координату по оси х для точки A: ");
// int x1 = Convert.ToInt32(ReadLine());
// WriteLine("Введите координату по оси y для точки A: ");
// int y1 = Convert.ToInt32(ReadLine());
// WriteLine("Введите координату по оси z для точки A: ");
// int z1 = Convert.ToInt32(ReadLine());
// WriteLine("Введите координату по оси x для  точки B: ");
// int x2 = Convert.ToInt32(ReadLine());
// WriteLine("Введите координату по оси y для  точки B: ");
// int y2 = Convert.ToInt32(ReadLine());
// WriteLine("Введите координату по оси z для  точки B: ");
// int z2 = Convert.ToInt32(ReadLine());

// double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));

// WriteLine($"Расстояние между двумя точками в 3D пространстве равно: {d:f2}");

//  через void метод :
void DistanceBetweenTwoPointsIn3D(int x1, int y1, int z1, int x2, int y2,  int z2)
{   
    double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Write($"Расстояние между двумя точками в 3D пространстве равно: {d:f2}");
}
WriteLine("Введите координаты x, y, z для каждой из 2-x точек чтобы узнать расстояние между ними: ");
DistanceBetweenTwoPointsIn3D(Convert.ToInt32(ReadLine()),Convert.ToInt32(ReadLine()),Convert.ToInt32(ReadLine()),Convert.ToInt32(ReadLine()),Convert.ToInt32(ReadLine()),Convert.ToInt32(ReadLine()));