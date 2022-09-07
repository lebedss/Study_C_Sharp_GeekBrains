// Задача 64: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5. -> ""5,4,3,2,1""
// M = 4; N = 8. -> ""8,7,6,5,4""


using static System.Console;
using System.Linq;
Clear();

Write("Введите значения M и N через пробел чтобы получить все натуральные числа в промежутке от M до N по убыванию: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
string answer = PrintMaxToMinRange(parameters[0], parameters[1]);
WriteLine(PrintMaxToMinRange(parameters[0], parameters[1]));


string PrintMaxToMinRange(int m, int n)
{
if (m <= n) return $"{PrintMaxToMinRange(m + 1, n)} {m}";
else return String.Empty;
}