// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите массив через пробел:");

int[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int[] array3 = new int[10].Select(x=> new Random().Next(-10,10)).ToArray();
WriteLine($"[{String.Join(" ", array3)}]");
ReversArray1(array);
WriteLine($"[{String.Join(" ", array)}]");
int[] array2 = ReversArray2(array);
WriteLine($"[{String.Join(" ", array2)}]");


void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp =inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = temp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] =inArray[inArray.Length-1-i];
    }
    
    return result;
}
