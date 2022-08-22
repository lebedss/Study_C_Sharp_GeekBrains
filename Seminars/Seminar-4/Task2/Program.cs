// **Задача 26:**
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();

Write("Введите число количество цифр которого вы хотите узнать: ");
int number = int.Parse(Console.ReadLine()!);
int answer = DigitsAmount(number);
Console.WriteLine($"Количество цифр в числе {number} = {answer}");


int DigitsAmount(int YourNumber)
{
    int counter = 0;
    for (int i = 0; i < YourNumber; i++)
    {
        counter += 1;
        YourNumber = YourNumber / 10;
    }
    // while (YourNumber != 0)
    // {
    //     counter += 1;
    //     YourNumber = YourNumber / 10;
    // }

    return counter;
}
