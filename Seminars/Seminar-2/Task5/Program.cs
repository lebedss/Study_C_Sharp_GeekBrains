/*Напишите программу, которая принимает на вход 
два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
using static System.Console;
// Задача 16. 
Clear();

void CheckMultiple(int FirstNumber, int SecondNumber)
{
    if (SecondNumber == FirstNumber * FirstNumber)
    {
        WriteLine("Да, одно из чисел является квадратом другого");
    }
    else
    {
        WriteLine("Нет, ни одно из указанных чисел не является квадратом другого");
    }
}
WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(ReadLine());

if (FirstNumber < SecondNumber)
{
    CheckMultiple(FirstNumber, SecondNumber);
}
else
{
    CheckMultiple(SecondNumber, FirstNumber);
}

//  В  1-ом семинаре (Task2) мы рассматривали другие подходы для решения этой задачи
//  В данном случае реализован алгоритм который говорит что одно из чисел является квадратом другого  - без уточнения какое именно...


