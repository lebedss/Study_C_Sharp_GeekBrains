// Напишите программу, которая  на вход принимает число и выдаёт его квадрат
// Число умноженное само на себя
// 4 ->16
// -3 ->9
//  -7-> 49
using static System.Console;
// Задача 0

Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
WriteLine($"Квадрат числа {number} = {number * number}");
WriteLine($"Квадрат числа {number} = {Convert.ToInt32(Math.Pow(number, 2))}");
