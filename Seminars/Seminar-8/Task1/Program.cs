// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


using static System.Console;
using System.Linq;
Clear();
Write("Введите количество строк и столбцов в массиве через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetRandomArray(parameters[0], parameters[1]);
PrintArray(matrix);
WriteLine();
PrintArray(SwitchFirstAndLastMatrixRow(matrix));


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


int[,] SwitchFirstAndLastMatrixRow(int[,] anyArray)
{
    for (int j = 0; j < anyArray.GetLength(0); j++)
    {
        int temp = anyArray[0,j];
        anyArray[0,j] = anyArray[anyArray.GetLength(0) -1, j];
        anyArray[anyArray.GetLength(0) -1, j] = temp;
    }
    return anyArray;
}