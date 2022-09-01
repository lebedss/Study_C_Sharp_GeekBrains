// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


using static System.Console;
Clear();


WriteLine("Введите количество строк и столбцов чтобы получить случайный двумерный массив из целочисленных чисел в диапазоне [1-100]: ");
int[,] randomArray = GetMatrixArray(int.Parse(ReadLine()!), int.Parse(ReadLine()!));
PrintMatrixArray(randomArray);
Write("Введите порядковый номер начиная с 0-го эле-та массива в строке чтобы узнать значение этого элемента: ");
WriteLine($"Результат: {FindArrayElement(randomArray, int.Parse(ReadLine()!))}");
Write("Введите порядковый номер (с 1-го) элемента в столбце чтобы узнать значение этого элемента: ");
WriteLine($"Результат: {FindArrayElement2(randomArray, int.Parse(ReadLine()!))}");
WriteLine("Введите индекс элемента[строка + столбец] - значение которого Вы хотите узнать: ");
FindElementInRandomArray(randomArray, int.Parse(ReadLine()!), int.Parse(ReadLine()!));


int[,] GetMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 101);
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

// Метод получает значение элемента по порядковому номеру в массиве (отчёт по строчкам и первый элемент(верхний левый угол) имеет порядковый номер 0)
string FindArrayElement(int[,] someArray, int findElement)
{
    string result = String.Empty;
    int elementRow = findElement / someArray.GetLength(0);
    int elementColumn = findElement % someArray.GetLength(1);
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            result = (elementRow < someArray.GetLength(0) && elementColumn < someArray.GetLength(1)) ? $"{someArray[elementRow, elementColumn]}" : "Такого элемента в нашем массиве нет.";
        }
    }
    return result;
}


// Метод находит значение элемента по порядковому номеру в массиве (отчёт по столбцам и первый элемент(верхний левый угол) имеет порядковый номер 1)
string FindArrayElement2(int[,] someArray2, int findElement2)
{
    string result = String.Empty;
    int elementRow = (findElement2 - 1) % (someArray2.GetLength(0) + 1);
    int elementColumn = (findElement2 - 1) / (someArray2.GetLength(1) + 1);
    for (int i = 0; i < someArray2.GetLength(0); i++)
    {
        for (int j = 0; j < someArray2.GetLength(1); j++)
        {
            result = (elementRow < someArray2.GetLength(0) && elementColumn < someArray2.GetLength(1)) ? $"{someArray2[elementRow, elementColumn]}" : "Такого элемента в нашем массиве нет.";
        }
    }
    return result;
}


// Метод находит значение любого элемента случайно сгенерированного массива по  заданному индексу
void FindElementInRandomArray(int[,] checkArray, int myElementrow, int myElementcolumn)
{
    if (myElementrow < checkArray.GetLength(0) && myElementcolumn < checkArray.GetLength(1))
    { // Строки и столбцы начинаются с 1
        // Console.WriteLine($"На позиции строка - {myElementrow}, столбец - {myElementcolumn} " +
        //                   $"находится элемент со значением: {checkArray[myElementrow - 1, myElementcolumn - 1]}");
        // Строки и столбцы начинаются с 0:      
        Console.WriteLine($"На позиции строка - {myElementrow}, столбец - {myElementcolumn} " +
                          $"находится элемент со значением: {checkArray[myElementrow, myElementcolumn]}");
    }
    else Console.WriteLine($"Cтрока - {myElementrow}, столбец - {myElementcolumn} - элемента на такой позиции в нашем массиве нет.");
}