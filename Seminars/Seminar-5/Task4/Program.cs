// Задача 35: 
// Задайте одномерный массив случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using static System.Console;
Clear();

Write("Введите количество элементов в массиве: ");
int[] RandomGeneratedResult = GetMyRandomArray(int.Parse(ReadLine()!));
WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] составляет: {NumberOfArraysElementsWithinRange(RandomGeneratedResult)}");


int NumberOfArraysElementsWithinRange(int[] MyArray)
{
    int counter = 0;
    foreach (int element in MyArray)
    {
        if (element >= 10 && element <= 99)
            counter++;
    }
    return counter;
}


int[] GetMyRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    WriteLine($"Одномерный массив случайных чисел: [{String.Join(",", array)}]");
    return array;
}