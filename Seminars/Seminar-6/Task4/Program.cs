// Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
using System.Linq;
Clear();

// Решение через Linq:
// Write("Введите число элементов в вашем массиве:");
// int[] array = new int[int.Parse(ReadLine()!)].Select(x => new Random().Next(-100, 101)).ToArray();
// int[] CopiedArray = array.Take(array.Length).ToArray();
// WriteLine($"Одномерный массив случайных чисел в диапазоне [-100,100]: [{String.Join(",", array)}]");
// Write($"Скопировали предыдущий массив  в новый массив: [{String.Join(";", CopiedArray)}]");

//  Отдельный метод который копирует массив поэлементно:

Write("Заполните массив целыми числами через пробел: ");
int[] array2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
Write($"Скопировали предыдущий массив поэлементно в новый массив и получили: [{String.Join(",", ArrayCopy(array2))}]");


int[] ArrayCopy(int[] AnyArray)
{
    int[] resultArray = new int[AnyArray.Length];
    for (int i = 0; i < AnyArray.Length; i++)
    {
        int temp = AnyArray[i];
        resultArray[i] = temp;
    }
    return resultArray;
}