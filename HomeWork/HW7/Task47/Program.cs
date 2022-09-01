// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();


WriteLine("Введите количество строк и столбцов в массиве: ");
double[,] finalArray = GetMatrixArray(int.Parse(ReadLine()!), int.Parse(ReadLine()!));
PrintMatrixArray(finalArray);


double[,] GetMatrixArray(int rows, int colums)
{
    double[,] result = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return result;
}


void PrintMatrixArray(double[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Write($"{myArray[i, j]} | ");
        }
        WriteLine();
    }
}