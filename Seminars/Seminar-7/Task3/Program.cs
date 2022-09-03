// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

using static System.Console;
using System.Linq;
Clear();

Write("Введите количество строк и столбцов в массиве через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetRandomArray(parameters[0], parameters[1]);
PrintArray(matrix);
WriteLine();
PrintArray(GetArrayWithSquareNumbers(matrix));


int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }

}


int[,] GetArrayWithSquareNumbers(int[,] anyArray)
{
    for (int i = 1; i < anyArray.GetLength(0); i++)
    {
        for (int j = 1; j < anyArray.GetLength(1); j++)
        {
            anyArray[i, j] *= (i % 2 == 0 && j % 2 == 0) ? anyArray[i, j] : 1;
        }
    }
    return anyArray;
}