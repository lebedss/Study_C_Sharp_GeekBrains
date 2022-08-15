/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
2679 -> 6*/
using static System.Console;
// Задача 13. 
Clear();
WriteLine("Введите ваше число: ");
int YourNumber = Convert.ToInt32(ReadLine());
if (YourNumber > 99 & YourNumber <= 999)
{
    int ThirdDigit = YourNumber % 10;
    WriteLine($"Третья цифра в вашем числе это {ThirdDigit}");
}
if (YourNumber > 999)
{
    WriteLine("Введите  общее количество цифр в вашем числе: ");
    int DigitsAmount = Convert.ToInt32(ReadLine());
    int ThirdDigit = YourNumber % Convert.ToInt32(Math.Pow(10, DigitsAmount - 2)) / Convert.ToInt32(Math.Pow(10, DigitsAmount - 3));
    WriteLine($"Третья цифра в вашем числе это {ThirdDigit}");
}
if (YourNumber <= 99)
{
    WriteLine("В этом числе третьей цифры нет ");
}
