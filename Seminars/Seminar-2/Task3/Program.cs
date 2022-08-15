/*Напишите программу, которая будет принимать на вход
 два числа и выводить, является ли второе число кратным 
 первому. Если число 2 не кратно числу 1, то программа
 выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
using static System.Console;
// Задача 12. 
Clear();
WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(ReadLine());

if (FirstNumber % SecondNumber == 0)
{
    WriteLine("Второе число кратно первому");
}
else
{
    WriteLine($"Второе число не кратно первому - вот остаток от деления: {FirstNumber % SecondNumber}");
}