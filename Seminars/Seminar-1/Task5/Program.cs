// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Задача № 1

using static System.Console;
Clear();
WriteLine("Введите число:");
int number = Convert.ToInt32(ReadLine());
if (number > 99 && number < 1000)
{
    int result = number % 10;
    WriteLine(result);
}
else
{
    WriteLine("Протри глаза - это не трёхзначное число!");
}