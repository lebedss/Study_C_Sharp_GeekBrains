// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран. Затем выведите тот же массив в обратном порядке.
// m = 3, n = 4.
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5 
// m = 3, n = 4.
// 5 4 3 2 
// 4 3 2 1 
// 3 2 1 0


using static System.Console;
using System.Linq;
Clear();


Write("Введите количество строк и столбцов в массиве через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
PrintArray(GetArray(parameters[0], parameters[1]));
WriteLine();
PrintArray(GetReversedArray(parameters[0], parameters[1]));


int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}


int[,] GetReversedArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = (rows - 1 - i) + (columns - 1 - j);
        }
    }
    return result;
}



