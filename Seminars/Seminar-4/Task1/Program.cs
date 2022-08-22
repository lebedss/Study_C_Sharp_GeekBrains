// Написать программу которая будет считать сумму чисел от 1 до числа A
// *Используем методы

using static System.Console;
Clear();
Write("Введите число A: ");
int A = int.Parse(ReadLine()!);
int sum = GetSum(A);
WriteLine($"Сумма чисел от 1 до {A} = {sum}");


int GetSum(int number)
{
    int result = 0;
    for (int i = 1; i < number; i++)
    {
        result += i;
    }
    return result;
}