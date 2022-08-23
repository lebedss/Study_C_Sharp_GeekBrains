// **Задача 33:** 
// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

using static System.Console;
Clear();

WriteLine("Введите количество элементов в массиве  и диапазон из 2 чисел для его случайного заполнения:");
int[] FilledArray = GetMyArray(int.Parse(ReadLine()!),int.Parse(ReadLine()!),int.Parse(ReadLine()!));
WriteLine();
WriteLine("Введите число чтобы проверить правда ли то что оно есть в нашем массиве:");
WriteLine(FindDigitInArray(FilledArray, int.Parse(ReadLine()!)));


bool FindDigitInArray(int[] AnyArray, int number)
{   
    foreach (int i in AnyArray)
    {
        if (i == number) return true;
    }
    return false;
}


int[] GetMyArray(int size, int minValue, int maxValue)
{
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    Write($"У нас получился вот такой массив: [{String.Join(",", MyArray)}]");
    return MyArray;
}