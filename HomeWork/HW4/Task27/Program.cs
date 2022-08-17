// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// using static System.Console;
// // Задача 27
// Clear();
// WriteLine("Введите число cумму цифр которого  вы хотите узнать: ");
// int number = Convert.ToInt32(ReadLine());
// int DigitsSum = 0;
// for (int i = 0; i < number; i++) // можно было использовать while number > 0 {.....}
// {
//     DigitsSum += number % 10;
//     number = number / 10;
// }
// Console.WriteLine($"Cумма цифр в  введённом числе {DigitsSum}");

// Напишите программу, которая принимает на вход число и выдаёт произведение цифр в числе.
// 1234 --> 24
// 6524 --> 240
using static System.Console;
// Задача самостоятельная
Clear();
WriteLine("Введите число произведение цифр которого вы хотите узнать: ");
int number = Convert.ToInt32(ReadLine());
int DigitsMultiplication = 1;
for (int i = 0; i < number; i++) // можно было использовать while number != 0 {.....}
{
    DigitsMultiplication *= number % 10;
    number = number / 10;
}
Console.WriteLine($"Произведение цифр в введённом числе {DigitsMultiplication}");
