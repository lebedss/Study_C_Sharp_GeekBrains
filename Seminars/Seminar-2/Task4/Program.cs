/*14. Напишите программу, которая принимает на вход 
число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
using static System.Console;
// Задача 14. 
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}