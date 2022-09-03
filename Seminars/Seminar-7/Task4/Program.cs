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


// Поскольку i=j  для элементов, находящихся на главной диагонали, то для обращения к соответствущему элементу достаточно использовать[i,i] или [j.j] 
// Проход  достаточно сделать  либо только по строкам либо только по столбцам...
// Также количество строк не всегда равно количеству столбцов поэтому ввели "плавающее ограничение" цикла(наименьшее значение) - size.
int GetSumOfMainDagonalElements(int[,] anyArray)
{
    int sum = 0;
    int size = anyArray.GetLength(0) < anyArray.GetLength(1) ? anyArray.GetLength(0) : anyArray.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sum += anyArray[i, i];
        Write($"Элемент: {anyArray[i, i]} ");
    }
    return sum;
}