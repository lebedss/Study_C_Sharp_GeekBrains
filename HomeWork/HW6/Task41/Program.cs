// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
using System.Linq;
Clear();
// Решение с помощью Count() в библиотеке Linq:

// Write("Введите произвольное количество целых чисел (положительных и отрицательных): через пробел: ");
// int count = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray().Where(a=>a>0).Count();
// Write($"Пользователь ввёл положительных чисел - {count}");


// Если мы не ищем лёгких путей можно сделать отдельный метод для ввода чисел с клавиатуры( с проверкой на пробелы)
// + Отдельный метод считающий количество положительных чисел:

Write("Введите произвольное количество целых чисел (положительных и отрицательных): ");
WriteLine($"Пользователь ввёл положительных чисел - {FindCountOfPositiveElements(GetArrayFromString(ReadLine()!))}");


int[] GetArrayFromString(string AnyStringArray)
{
    string[] MyStringArray = AnyStringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[MyStringArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(MyStringArray[i]);
    }
    WriteLine($"[{String.Join(",", result)}]");
    return result;
}


int FindCountOfPositiveElements(int[] AnyArray)
{
    int count = 0;
    foreach (int element in AnyArray)
    {
        count += element > 0 ? 1 : 0;
    }
    return count;
}


