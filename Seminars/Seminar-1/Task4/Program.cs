﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
//  Задача 5

using static System.Console;
Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
// for (int i = -number; i <= number; i++)
// {
//     WriteLine($'{i} ");
// }
int count = -number;
while (count <= number)
{
    Write($"{count} ");
    count++;
}