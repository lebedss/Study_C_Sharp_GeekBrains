// **Задача 30:**
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

// 1 подход : мы  инициировали наш массив определённой длинны (8)  в 9-ой строке и применили к нему метод который и заполняет и выводит результат
// int[] array = new int[8];
// FillAndPrintRandomArray(array);

//  2 подход : мы инициировали наш массив внутри метода GetArray (длинна заранее не определена - алгоритм более универсален)
//  Используем метод GetArray для заполнения массива случайными числами  и метод PrintArray для вывода результата в консоль
Write("Введите количество элементов в вашем массиве: ");
int []  ResultArray = GetArray (int.Parse(ReadLine()!));
PrintArray(ResultArray);

// Метод для 1-го подхода (комбинированный)
// void FillAndPrintRandomArray(int[] AnyArray)
// {
//     WriteLine("Массив из 8 элементов, заполненный нулями и единицами в случайном порядке выглядит так:");
//     Write("[");
//     int length = AnyArray.Length;
//     for (int i = 0; i < length; i++)
//     {
//         AnyArray[i] = new Random().Next(0, 2);
//         Write($"{AnyArray[i]}");
//         if (i < AnyArray.Length - 1) Write(",");
//     }
//     Write("]");
// }

//  2  отдельных метода для 2-го подхода:

int [] GetArray(int number)
{
    int[] MyArray = new int[number];
    for (int i = 0; i < number; i++)
    {
        MyArray[i] = new Random().Next(0, 2);
    }
    return MyArray;
}


void PrintArray(int[] FinalArray)
{
    WriteLine("Массив, заполненный нулями и единицами в случайном порядке выглядит так:");
    Write("[");
    for (int i = 0; i < FinalArray.Length; i++)
    {
        Write($"{FinalArray[i]}");
        if (i < FinalArray.Length - 1) Write(",");
    }
    Write("]");
}