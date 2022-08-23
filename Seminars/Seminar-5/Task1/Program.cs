// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

using static System.Console;
Clear();
int[] array = GetArray(12, -9, 9);
WriteLine($"{String.Join(" ", array)}");
int positiveSum = 0;
int negativeSum = 0;
foreach (int item in array)
{
    positiveSum += item > 0 ? item : 0;
    negativeSum += item < 0 ? item : 0;
}
WriteLine($"Cумма положительных элементов массива = {positiveSum}");
WriteLine($"Cумма отрицательных элементов массива = {negativeSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}