// Задача 59: Из двумерного массива целых чисел удалить строки и столбцы,
// на пересечении которых расположен наименьший элемент.


using static System.Console;
Clear();
int n = int.Parse(ReadLine());
int m = int.Parse(ReadLine());
int[,] array = GetArray(n, m);
PrintArray(array);
WriteLine();
int[,] resultArray = GetResultMatrix(array);
PrintArray(resultArray);

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

int[,] GetArray(int rows, int columns)
{
Random rnd = new Random();
int[,] result = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
result[i, j] = rnd.Next(10, 30);
}
}
return result;
}

//Поиск минимального элемента
int GetMinElement(int[,] array)
{
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (min > array[i, j]) min = array[i, j];
}
}
return min;
}

//Формирование массива координат
CoordinateMatrix[] GetCoordinates(int[,] inArray)
{
CoordinateMatrix[] cor = new CoordinateMatrix[inArray.GetLength(0) * inArray.GetLength(1)];
for (int i = 0; i < cor.Length; i++)
{
cor[i].Column = -1;
cor[i].Row = -1;
}
int min = GetMinElement(inArray);
WriteLine($"Минимальный элемент = {min}");
int k = 0;
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
if (min == array[i, j])
{
cor[k].Row = i;
cor[k].Column = j;
k++;
}
}
}
WriteLine($"Всего найдено {k} элемент(а/ов)");
WriteLine();

//Уберем лишние координаты, за счет создания нового массива
CoordinateMatrix[] result = new CoordinateMatrix[k];
for (int i = 0; i < k; i++)
{
    result[i] = cor[i];
}
return result;
}

//Формирование результирующей матрицы
int[,] GetResultMatrix(int[,] baseArray)
{
CoordinateMatrix[] coordinates = GetCoordinates(array);

//Отдельно формируем строки и столбцы, чтобы исключить удаление столбцов или строк в которых находятся 2 минимальных элемента
int[] deleteRows = GetDeleteRows(coordinates);
int[] deleteColumns = GetDeleteColumns(coordinates);
int[,] resultMatrix = new int[baseArray.GetLength(0) - deleteRows.Length, baseArray.GetLength(1) - deleteColumns.Length];
//Вычисляем строки и столбцы которые надо удалить
int rowCount = 0;
for (int i = 0; i < baseArray.GetLength(0); i++)
{
    //Если встретили строку, пропускаем
    if (FindElement(i, deleteRows)) continue;
    int columnCount = 0;
    for (int j = 0; j < baseArray.GetLength(1); j++)
    {
        //Если встретили столбец, пропускаем
        if (FindElement(j, deleteColumns)) continue;
        resultMatrix[rowCount, columnCount] = baseArray[i, j];
        columnCount++;
    }
    rowCount++;
}
return resultMatrix;
}

//Получение массива номеров столбцов
int[] GetDeleteColumns(CoordinateMatrix[] coordinate)
{
int[] deleteColumns = new int[coordinate.Length];
for (int i = 0; i < coordinate.Length; i++)
{
deleteColumns[i] = -1;
}
int columnCount = 0;
//Вычисляем столбцы которые надо удалить
foreach (var item in coordinate)
{
if (!FindElement(item.Column, deleteColumns))
{
deleteColumns[columnCount] = item.Column;
columnCount++;
}
}
int[] resDelCols = new int[columnCount];
for (int i = 0; i < columnCount; i++)
{
resDelCols[i] = deleteColumns[i];
}
return resDelCols;
}

//Получение массива номеров строк
int[] GetDeleteRows(CoordinateMatrix[] coordinate)
{
int[] deleteRows = new int[coordinate.Length];
for (int i = 0; i < coordinate.Length; i++)
{
deleteRows[i] = -1;
}
int rowCount = 0;
//Вычисляем столбцы которые надо удалить
foreach (var item in coordinate)
{
if (!FindElement(item.Row, deleteRows))
{
deleteRows[rowCount] = item.Row;
rowCount++;
}
}
int[] resDelRows = new int[rowCount];
for (int i = 0; i < rowCount; i++)
{
resDelRows[i] = deleteRows[i];
}
return resDelRows;
}

//Поиск элемента в массиве
bool FindElement(int element, int[] array)
{
foreach (var item in array)
{
if (element == item) return true;
}
return false;
}

struct CoordinateMatrix
{
public int Row;
public int Column;
}