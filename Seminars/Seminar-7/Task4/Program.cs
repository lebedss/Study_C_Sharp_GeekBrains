// Задача 51: 
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

using static System.Console;
Clear();

WriteLine("Введите количество строк и столбцов в массиве: ");
int[,] matrix = GetRandomMatrix(int.Parse(ReadLine()!), int.Parse(ReadLine()!));
PrintMatrix(matrix);
WriteLine($"Cуммa элементов, находящихся на главной диагонали = {GetSumOfMainDagonalElements(matrix)}");


int[,] GetRandomMatrix(int rows, int columns)
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


void PrintMatrix(int[,] array)
{
    WriteLine("Получили вот такой массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }

}


// Поскольку i=j  на главной диагонали для вызова соответствущего элемента достаточно использовать [i,i] или [j.j] 
// И проход  достаточно сделать  либо по только строкам либо только по столбцам...
int GetSumOfMainDagonalElements(int[,] anyArray)
{
    int sum = 0;
    for (int i = 0; i < anyArray.GetLength(0); i++)
    {
        sum += anyArray[i, i];
    }
    return sum;
}