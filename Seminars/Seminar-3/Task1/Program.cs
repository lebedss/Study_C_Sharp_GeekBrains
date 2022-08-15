// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
using static System.Console;
// Задача 18:
Clear();
WriteLine("Введите число от 1 до 4 обозначающее номер четверти в системе координат (x и y): ");
int number = Convert.ToInt32(ReadLine());
switch (number)
{
    case 1:
        {
            WriteLine("x > 0 && y > 0");
            break;
        }
    case 2:
        {
            WriteLine("x < 0 && y > 0");
            break;
        }
    case 3:
        {
            WriteLine("x < 0 && y < 0");
            break;
        }
    case 4:
        {
            WriteLine("x > 0 && y < 0");
            break;
        }
    default:
        {
            WriteLine("Ошибка ввода данных - попробуйте ещё раз");
            break;
        }
}