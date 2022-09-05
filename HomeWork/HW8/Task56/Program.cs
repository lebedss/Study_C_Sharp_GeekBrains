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
WriteLine($"Cумма каждой строки(oт 0 до N) прямоугольного двумерного массива: [{String.Join(";", PutSumOfMatrixRawsInNewArray(matrix))}]");
Write($"Номер строки с наименьшей суммой элементов: {FindRawWithMinElementsSum(PutSumOfMatrixRawsInNewArray(matrix))}");


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


int[] PutSumOfMatrixRawsInNewArray(int[,] myArray)
{
    int[] newArray = new int[myArray.GetLength(0)];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            sum += myArray[i, j];
        }
        newArray[i] = sum;
    }
    return newArray;
}


int FindRawWithMinElementsSum(int[] MatrixLinesSumArray)
{
    int min = MatrixLinesSumArray[0];
    int position = 0;
    for (int i = 0; i < MatrixLinesSumArray.Length; i++)
    {
        if (MatrixLinesSumArray[i] < min)
        {
            min = MatrixLinesSumArray[i];
            position = i;
        }
    }
    return position;
}

