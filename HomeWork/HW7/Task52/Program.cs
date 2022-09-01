// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();


WriteLine("Введите количество строк и столбцов чтобы получить случайный двумерный массив из целых чисел в диапазоне [1-9]: ");
int[,] randomArray = GetMatrixArray(int.Parse(ReadLine()!), int.Parse(ReadLine()!));
WriteLine();
PrintMatrixArray(randomArray);
FindArithmeticMean(randomArray);

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


void PrintMatrixArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Write($"{myArray[i, j]} ");
        }
        WriteLine();
    }
}


void FindArithmeticMean(int[,] anyArray)
{
    double arithmeticMean = 0;
    double sumOfcolumn = 0;
    Write("Cреднее арифметическое элементов в каждом столбце: ");
    for (int j = 0; j < anyArray.GetLength(1); j++)
    {
        for (int i = 0; i < anyArray.GetLength(0); i++)
        {
            sumOfcolumn += anyArray[i, j];
        }
        arithmeticMean = sumOfcolumn / anyArray.GetLength(0);
        Write($"{arithmeticMean:f2}; ");
        arithmeticMean = 0;
        sumOfcolumn =0;
    }
}
