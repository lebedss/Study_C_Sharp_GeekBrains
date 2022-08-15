/*Напишите программу,
 которая выводит случайное трехзначное число и
 удаляет вторую цифру этого числа
*/
using static System.Console;
// Задача 11. 
Clear();
int number = new Random().Next(100, 1000);

int FirstDigit = number / 100;
int LastDigit = number % 10;

WriteLine($"случайное трёхзначное число : {number}");
WriteLine($"первая цифра введённого числа: {FirstDigit}");
WriteLine($"последняя цифра введённого числа: {LastDigit}");

Write($"Результат после удаления второй цифры из введённого числа: {FirstDigit}{LastDigit}");