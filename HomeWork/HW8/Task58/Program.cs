// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Алгоритм:
// Матрицы можно перемножать : если количество столбцов первой матрицы равно количеству строк второй
// Если есть 2 матрицы A и B, то в результате умножения мы получаем  A[i,n] * B[n,j] = C[i,j] где в скобках указана размерность  - строки и столбцы
// Чтобы получить элементы результирующей матрицы нужно перемножить попарно  элементы в соответствующей строке матрицы A  
// c элементами в соответствующем столбце матрицы B и сложить промежуточные результаты.
// матрица A
// 8 8 4      
// 4 1 4      
// 6 8 1      
// матрица B
// 9 4 3      
// 5 8 6      
// 3 2 6  
// Первая строка результирующей матрицы С:
// C[1,1]  = 8*9 + 8*5 + 4*3 => 124
// C[1,2]  = 8*4 + 8*8 + 4*2 => 104
// C[1,3]  = 8*3 + 8*6 + 4*6 => 96
// Вторая строка результирующей матрицы С:
// C[2,1]  = 4*9 + 1*5 + 4*3 => 53
// C[2,2]  = 4*4 + 1*8 + 4*2 => 32
// C[2,3]  = 4*3 + 1*6 + 4*6 => 42
// Третья строка результирующей матрицы С:
// C[3,1]  = 6*9 + 8*5 + 1*3 => 97
// C[3,2]  = 6*4 + 8*8 + 1*2 => 90
// C[3,3]  = 6*3 + 8*6 + 1*6 => 72
// Результат матрица С[3,3]:
// 124 104 96 
// 53 32 42   
// 97 90 72   


using static System.Console;
using System.Linq;
Clear();

Write("Введите размер первого массива - количество строк и столбцов, мин и макс значения (целые числа) через пробел: ");
int[] parameters1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = GetMatrixArray(parameters1[0], parameters1[1], parameters1[1], parameters1[3]);
Write("Введите размер второго массива - количество строк и столбцов, мин и макс значения (целые числа) через пробел: ");
int[] parameters2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
int[,] matrix2 = GetMatrixArray(parameters2[0], parameters2[1], parameters2[2], parameters2[3]);
WriteLine();
PrintMatrixArray(matrix1);
WriteLine();
PrintMatrixArray(matrix2);
WriteLine();
PrintMatrixArray(MultiplicationOfArrays(matrix1, matrix2));


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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


int[,] MultiplicationOfArrays(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                for (int n = 0; n < firstArray.GetLength(1); n++)
                {
                    resultArray[i, j] += firstArray[i, n] * secondArray[n, j];
                }
            }
        }
    }
    else WriteLine("Данные матрицы невозможно перемножить!");
    return resultArray;
}
