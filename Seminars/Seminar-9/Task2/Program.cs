// Задача 65: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Реализация через рекурсию

using static System.Console;
Clear();
WriteLine("Задайте значения M и N чтобы получить натуральные числа в промежутке от от M до N: ");
int firstNumber = int.Parse(ReadLine()!);
int secondNumber = int.Parse(ReadLine()!);
WriteLine($" {GetStringOfNumbers1(firstNumber, secondNumber)}");
WriteLine($" {GetStringOfNumbers2(firstNumber, secondNumber)}");


string GetStringOfNumbers1(int M, int N)
{
    if (M == N) return $"{M}";
    else if (M > N) return GetStringOfNumbers1(M - 1, N) + $" {M}";
    return GetStringOfNumbers1(N - 1, M) + $" {N}";
}


string GetStringOfNumbers2(int M, int N)
{
    return (M == N) ? $"{M} " : (M < N) ? $"{M} " + GetStringOfNumbers2(M + 1, N) : $"{N} " + GetStringOfNumbers2(N + 1, M);
}