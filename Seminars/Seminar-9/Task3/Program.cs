// Задача 67: 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//  Реализация через рекурсию

using static System.Console;
Clear();
Write("Задайте целое число чтобы получить сумму его цифр: ");
int number = int.Parse(ReadLine()!);
WriteLine($"Сумма цифр вашего числа = {SumOfDigitsInNumber1(number)}");
WriteLine($"Сумма цифр вашего числа = {SumOfDigitsInNumber2(number)}");


int SumOfDigitsInNumber1(int myNumber)
{
    if (myNumber > 0)
    {
        return myNumber % 10 + SumOfDigitsInNumber1(myNumber / 10);
    }
    return 0;
}


int SumOfDigitsInNumber2(int myNumber)
{
    return (myNumber > 0) ? myNumber % 10 + SumOfDigitsInNumber2(myNumber / 10) : 0;
}