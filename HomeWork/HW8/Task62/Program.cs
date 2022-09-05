// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using static System.Console;
using System.Linq;
Clear();

Write("Введите целое чётное число N [2,10], чтобы получить и заполнить спирально прямоугольный двумерный массив с размером N x N: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
string[,] matrix = GetSpiralMatrix(parameters[0], parameters[0]);
PrintMyStringMatrix(matrix);


string[,] GetSpiralMatrix(int rows, int colums)
{
    string[,] spiralMatrix = new string[rows, colums];
    int i, j;
    int firstTemp = 0;
    int secondTemp = 1;
    while ((rows - 2 * firstTemp) * (colums - 2 * firstTemp) != 0)
    {
        i = firstTemp;
        for (j = firstTemp; j < colums - 1 - firstTemp; j++)
        {
            spiralMatrix[i, j] = secondTemp.ToString("00");
            secondTemp++;
        }
        for (i = firstTemp; i < rows - 1 - firstTemp; i++)
        {
            spiralMatrix[i, j] = secondTemp.ToString("00");
            secondTemp++;
        }
        for (j = colums - 1 - firstTemp; j > firstTemp; j--)
        {
            spiralMatrix[i, j] = secondTemp.ToString("00");
            secondTemp++;
        }
        for (i = rows - 1 - firstTemp; i > firstTemp; i--)
        {
            spiralMatrix[i, j] = secondTemp.ToString("00");
            secondTemp++;
        }
        firstTemp++;
    }
    return spiralMatrix;
}


void PrintMyStringMatrix(string[,] inArray)
{
    if (inArray.GetLength(0) <= 10)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]}  ");
            }
            WriteLine();
        }
    }
    else
    WriteLine("Ошибка ввода данных  -  еще раз введите или 2 || 4 || 6 || 8 || 10");
}


