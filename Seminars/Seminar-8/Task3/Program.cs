// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Алгоритм:
// 1. Ввод размера массива
// 2. Создание случайного массива
// 3. Разворачиваем двумерный массив в строку
// 4. Сортируем
// 5. Считаем


using static System.Console;
using System.Linq;
Clear();
Write("Введите количество строк и столбцов, max и min значения в массиве через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(array);
WriteLine();
int[] rowArray = GetRowArray(array);  //  сортировка через Linq:  GetRowArray(array).OrderBy(x=>x).ToArray();
SortArray(rowArray);
WriteLine(String.Join(" ", rowArray));
PrintData(rowArray);


int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
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


int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            k++;
        }
    }
    return result;
}


void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}


void PrintMatrix(int[,] inArray)
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


void PrintData(int[] inArray)
{
    int element = inArray[0];
    int counter = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (element != inArray[i])
        {
            WriteLine($"{element}-->{counter};");
            element = inArray[i];
            counter = 1;
        }
        else
        {
            counter++;
        }
    }
    WriteLine($"{element}-->{counter};");
}