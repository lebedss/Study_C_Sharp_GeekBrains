// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


using static System.Console;
using System.Linq;
Clear();
Write("Введите количество строк и столбцов в массиве через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
if (parameters[0] != parameters[1])
{
    WriteLine("Cтроки на столбцы в таком массиве поменять местами нельзя!");
    return;
}
int[,] matrix = GetRandomArray(parameters[0], parameters[1]);
PrintArray(matrix);
WriteLine();
PrintArray(SwitchMatrixRowsToStrings(matrix));


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


int[,] SwitchMatrixRowsToStrings(int[,] anyArray)
{
    int[,] result = new int[anyArray.GetLength(0), anyArray.GetLength(1)];
    for (int i = 0; i < anyArray.GetLength(0); i++)
    {
        for (int j = 0; j < anyArray.GetLength(1); j++)
        {
            result[j, i] = anyArray[i, j];
        }
    }
    return result;
}

//  Другой подход через void метод и буферную переменную
// SwitchMatrixRowsToStrings2(int[,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             int temp = myArray[i, j];
//             myArray[i, j] = myArray[j, i];
//             myArray[j, i] = temp;
//         }
//     }
// }