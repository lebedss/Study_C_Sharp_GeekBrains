/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
Не использовать строки, только математически */

using static System.Console;
Clear();
//  Задача 10
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
if (number > 99 && number < 1000)
{
    int SecondDigit = number / 10 % 10;
    WriteLine(SecondDigit);
}
else
{
    WriteLine("Вы ошиблись и ввели не трёхзначное число ");
}

