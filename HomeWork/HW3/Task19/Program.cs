// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static System.Console;
// Задача 19
Clear();
Write("Введите какое-нибудь пятизначное число: ");
int number = Convert.ToInt32(ReadLine());

/*
//  Прямой подход через условие + максимально подробный алгоритм работы с цифрами числа:
int FirstDigit = number % Convert.ToInt32(Math.Pow(10, 5)) / Convert.ToInt32(Math.Pow(10, 4));
int SecondDigit = number % Convert.ToInt32(Math.Pow(10, 4)) / Convert.ToInt32(Math.Pow(10, 3));
int PenultimateDigit = number % Convert.ToInt32(Math.Pow(10, 2)) / Convert.ToInt32(Math.Pow(10, 1));
int LastDigit = number % Convert.ToInt32(Math.Pow(10, 1)) / Convert.ToInt32(Math.Pow(10, 0));
if (FirstDigit == LastDigit && SecondDigit == PenultimateDigit)
{
    Write("Это число палиндром"); 
}
else
{
    Write("Это число не палиндром");
}
*/

//  Тернарная условная операция через bool + компактный код + проверка на случай опечатки при вводе данных:
/*
if (number > 9999 && number < 100000)
{
    int FirstDigit = number % Convert.ToInt32(Math.Pow(10, 5)) / Convert.ToInt32(Math.Pow(10, 4));
    int SecondDigit = number % Convert.ToInt32(Math.Pow(10, 4)) / Convert.ToInt32(Math.Pow(10, 3));
    bool answer = ((FirstDigit == number % 10 && SecondDigit == number % 100 / 10) ? true : false);
    Write($"Правда ли что это число палиндром? --> {answer}");
}
else
{
    Write($" Ошибка ввода данных - попробуйте еще раз");
}
*/
//  Тернарная условная операция через string +  ещё более компактный код + проверка на случай опечатки при вводе данных
if (number > 9999 && number < 100000)
{
    int FirstDigit = number % 100000 / 10000;
    int SecondDigit = number % 10000 / 1000;
    string answer = ((FirstDigit == number % 10 && SecondDigit == number % 100 / 10) ? "Да это палиндром" : "Нет это не палиндром");
    Write(answer);
}
else
{
    Write($" Ошибка ввода данных - попробуйте еще раз");
}