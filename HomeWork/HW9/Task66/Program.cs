// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
using System.Linq;
Clear();

Write("Введите значения M и N через пробел чтобы получить cумму натуральных элементов в промежутке от M до N: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int sum = GetElementsInRangeSum(parameters[0], parameters[1]);
WriteLine($"Сумма натуральных элементов в промежутке от M до N = {GetElementsInRangeSum(parameters[0], parameters[1])}");


int GetElementsInRangeSum(int m, int n) {
    if(m > n)
    {
        return 0;
    }
    return m + GetElementsInRangeSum(m+ 1, n);
}

