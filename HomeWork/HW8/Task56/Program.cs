// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static System.Console;
using System.Linq;
Clear();

Write("Введите  целое число - N, чтобы получить прямоугольный двумерный массив N x N: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[0]);
PrintMatrixArray(matrix);
// GetMinSumOfMatrixRaw(matrix);
WriteLine($"Номер строки с наименьшей суммой элементов: {GetTheMatrixLineWithMinSum(matrix)}");


// void GetMinSumOfMatrixRaw(int[,] anyArray)
// {
//     int minSum = Int32.MaxValue; //  Int32.MaxValue это константа - крайнее значение, которое может принять тип int : 2147483647
//     int linePosition = 0;
//     for (int i = 0; i < anyArray.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < anyArray.GetLength(1); j++)
//         {
//             sum += anyArray[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             linePosition++;
//         }
//     }
//     WriteLine($"Строка с наименьшей суммой элементов: {linePosition}, а сумма элементов в этой строке: {minSum}");
// }


int[,] GetMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}


int MatrixLineElementsSum(int[,] anyArray, int linePosition)
{
    int sumLine = anyArray[linePosition, 0];
    for (int j = 1; j < anyArray.GetLength(1); j++)
    {
        sumLine += anyArray[linePosition, j];
    }
    return sumLine;
}


int GetTheMatrixLineWithMinSum(int[,] myArray)
{
    int minLinesum = 0;
    int sumInline = MatrixLineElementsSum(myArray, 0);
    for (int i = 1; i < myArray.GetLength(0); i++)
    {
        int tempLineSum = MatrixLineElementsSum(myArray, i);
        if (sumInline > tempLineSum)
        {
            sumInline = tempLineSum;
            minLinesum = i;
        }
    }
    return minLinesum;
}



