// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();

Write("Введите количество элементов в массиве: ");
WriteLine($"Разницу между максимальным и минимальным элементом массива: {DifferenceBetweenArraysMaxAndMin(FillArrayWithRandomDoubleNumbers((int.Parse(ReadLine()!))))}");


double DifferenceBetweenArraysMaxAndMin(double[] array)
{
    double ArrayMax = array[0];
    double ArrayMin = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        ArrayMax = array[i] > ArrayMax ? array[i] : ArrayMax;
        ArrayMin = array[i] < ArrayMin ? array[i] : ArrayMin;
    }
    return ArrayMax - ArrayMin;
}


double[] FillArrayWithRandomDoubleNumbers(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 3); 
        // NextDouble() Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.
        // Round(double a, int b): возвращает число a, округленное до определенного количества знаков после запятой, представленного параметром b
    }
    WriteLine($"Массив заполненный случайными вещественными числами выглядит вот так: [{String.Join("; ", array)}]");
    return array;
}