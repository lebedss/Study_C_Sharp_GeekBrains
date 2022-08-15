// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

using static System.Console;
//  Задача 3
WriteLine("Введите число  от 1 до 7: ");
int number = Convert.ToInt32(ReadLine());
if (number == 1)
{
    WriteLine("Сегодня понедельник");
}
if (number == 2)
{
    WriteLine("Сегодня  вторник");
}
if (number == 3)
{
    WriteLine("Сегодня среда");
}
if (number == 4)
{
    WriteLine("Сегодня четверг");
}
if (number == 5)
{
    WriteLine("Сегодня пятница");
}
if (number == 6)
{
    WriteLine("Сегодня суббота");
}
if (number == 7)
{
    WriteLine("Сегодня воскресенье");
}
if (number > 7 || number < 1)
{
    WriteLine("Ты слепой или просто не умеешь считать до 7 :(");
}
