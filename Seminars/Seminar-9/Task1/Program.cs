// Задача 63 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//  Реализация через рекурсию


using static System.Console;
Clear();
Write("Введите значение N чтобы получить натуральные числа в промежутке от 1 до N: ");
int num = int.Parse(ReadLine()!);
WriteLine($" {GetStringNumbers(num)}");


string GetStringNumbers(int N)
{
    if (N == 1) return "1";
    return GetStringNumbers(N - 1) + $" {N}";  // cобираем строчку с конца
}


// Через тернарный оператор
// string GetStringNumbers1(int N)
// {
//     return (N == 1) ? "1" : GetStringNumbers(N - 1) + $" {N}";
// }