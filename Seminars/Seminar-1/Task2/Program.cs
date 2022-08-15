// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

using static System.Console;
Clear();
//  Задача 1
WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int SecondNumber= Convert.ToInt32(ReadLine());
/* Через ветвление (условие)
if (FirstNumber == SecondNumber * SecondNumber)
{
    WriteLine("Первое число является квадратом второго.");
}
else if (SecondNumber == FirstNumber * FirstNumber)
{
    WriteLine("Второе число является квадратом первого.");
}
else
{
    WriteLine("Ни одно из введённых чисел не является квадратом другого.");
}
*/
// Добавили метод Math используем квадратный корень

if (FirstNumber == Convert.ToInt32(Math.Sqrt(SecondNumber)))
{
    WriteLine("Первое число является квадратом второго.");
}
else if (SecondNumber == Convert.ToInt32(Math.Sqrt(FirstNumber)))
{
    WriteLine("Второе число является квадратом первого.");
}
else
{
    WriteLine("Ни одно из введённых чисел не является квадратом другого.");
}



