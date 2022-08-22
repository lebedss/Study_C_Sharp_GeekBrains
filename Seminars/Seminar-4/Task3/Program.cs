// **Задача 28:**
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// *Используем метод
using static System.Console;
Clear();

Write("Введите число чтобы узнать произведение чисел от 1 до этого числа: ");
int number = int.Parse(ReadLine()!);
if (number >1)
{
double answer = NumbersMultiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {answer}");
}
else
{
Console.WriteLine($"Ошибка ввода данных - попробуйте ввести  какое-нибудь число больше 1 еще раз");
}


double NumbersMultiplication(int YourNumber)
{
    int counter = 1;
    for (int i = 1; i <= YourNumber; i++)
    {
        counter *= i;
    }
    return counter;
}


// Рекурсия (метод Factorial вызывает сам себя)
// double Factorial(int n)
// {
//     //  1! =1
//     //  0!=1
//     В условии задачи произведение чисел от 1 до N  поэтому условие с 0  не добавляем.
//     Факториа́л — функция, определённая на множестве неотрицательных целых чисел. В условии задачи явно не сказано что речь идёт именно о целых числах поэтому данное решение основано на допущении что это так.
//     if (n == 1) return 1;
//     else  return n* Factorial(n -1);
// }