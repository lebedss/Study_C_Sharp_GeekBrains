// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

Write("Введите количество элементов в массиве: ");
WriteLine($"Количество чётных чисел в массиве: {FindTotalAmountOfEvenArrayNumbers(FillArrayWithRandomThreeDigitsNumbers(int.Parse(ReadLine()!)))}");

int FindTotalAmountOfEvenArrayNumbers(int[] AnyArray)
{
    int counter = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        counter +=AnyArray[i] % 2 == 0 ? 1 : 0;
    }
    return counter;
}


int[] FillArrayWithRandomThreeDigitsNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    WriteLine($"Массив заполненный случайными положительными трёхзначными числами: [{String.Join(",", array)}]");
    return array;
}
