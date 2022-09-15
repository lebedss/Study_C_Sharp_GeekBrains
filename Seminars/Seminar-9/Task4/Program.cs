// Задача 69: 
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// Реализация через рекурсию

using static System.Console;
Clear();
WriteLine("Задайте два целых числа A и B, чтобы возвести число А в степень B: ");
int firstNumber = int.Parse(ReadLine()!);
int secondNumber = int.Parse(ReadLine()!);
WriteLine($"{firstNumber} в степени {secondNumber} = {RaiseNumberToPower1(firstNumber, secondNumber)}");
WriteLine($"{firstNumber} в степени {secondNumber} = {RaiseNumberToPower2(firstNumber, secondNumber)}");


int RaiseNumberToPower1(int A, int B)
{
    if (B > 0)
    {
        return A * RaiseNumberToPower1(A, B - 1);
    }
    return 1;
}


int RaiseNumberToPower2(int A, int B)
{
    return (B > 0) ? A * RaiseNumberToPower1(A, B - 1) : 1;
}