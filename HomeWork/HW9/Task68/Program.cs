// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// Функция Аккермана A(m,n), определенная следующим образом:
// A(m,n) = { 1) n+1 & m=0;  \\  2) A(m-1,1) & m>0, n=0;  \\ 3) A(m-1 A(m,n-1)) & m>0, n>0 }

using static System.Console;
using System.Linq;
Clear();

Write("Введите два неотрицательных числа m и n через пробел чтобы получить результат вычисления функции Аккермана: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int functionResult = CalculateAckermannFunction(parameters[0], parameters[1]);
WriteLine($"A(m,n) = {CalculateAckermannFunction(parameters[0], parameters[1])}");

int CalculateAckermannFunction(int m, int n) 
{
        // Базовый случай
        if (m == 0) {
            return n + 1;
        } // Рекурсивное условие 1
        else if (n == 0 && m > 0) {
            return CalculateAckermannFunction(m - 1, 1);
        } // Рекурсивное условие 2
        else {
            return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
        }
}
