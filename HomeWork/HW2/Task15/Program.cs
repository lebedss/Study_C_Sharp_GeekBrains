/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
using static System.Console;
// Задача 15. 
Clear();
Write("Введите порядковый номер для дня недели: ");
int DayNumber = Convert.ToInt32(ReadLine());
void CheckingWhetherTheDayOfTheWeekIsDayOff(int dayNumber)
{
    if (DayNumber == 6 || DayNumber == 7)
    {
        WriteLine("Да,  это выходной");
    }
    else if (DayNumber < 1 || DayNumber > 7)
    {
        WriteLine("Вы неправильно ввели номер или Вы с другой планеты");
    }
    else WriteLine("Нет,  это не выходной");
}
CheckingWhetherTheDayOfTheWeekIsDayOff(DayNumber);