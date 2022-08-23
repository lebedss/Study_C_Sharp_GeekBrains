// **Задача 32:**
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;
Clear();
//  Ввод через консоль количества элементов + случайная генерация цифр(в указанном диапазоне) которые заполнят массив
//  Затем положительные элементы меняем на соответствующие отрицательные
Write("Введите количество элементов в массиве: ");
int[] RandomGeneratedResult = GetMyArray(int.Parse(ReadLine()!));
WriteLine($"[{String.Join(",", ArrayPlusToMinus(RandomGeneratedResult))}]");
//  Заполняем вручную через консоль наш массив целыми числами ( Напомню:  это  натуральные цифры обратные им и 0)
//  Затем положительные элементы меняем на соответствующие отрицательные
Write("Заполните массив используя целые числа: ");
int[] ManualInputResult = GetArrayFromString(ReadLine()!);
Write($"[{String.Join(",", ArrayPlusToMinus(ManualInputResult))}]");


int[] ArrayPlusToMinus(int[] SomeArray)
{
    int[] array = new int[SomeArray.Length];
    for (int i = 0; i < SomeArray.Length; i++)
    {
        SomeArray[i] *= (-1);
        array[i] = SomeArray[i];
    }
    return array;
}


//  Для удобства зрительного восприятия я решил ограничить диапазон чисел внутри массива общим количеством элементов ( +-size)
//  Можно было взять любые числа для нашего диапазона...
int[] GetMyArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-size, size + 1);
    }
    WriteLine($"[{String.Join(",", array)}]");
    return array;
}

// Метод заполнения массива вручную (Вводим строку - получаем числа)
// Поскольку мы задействовали  в нашем методе метод Split () который разбивает (делит) строку на две или более подстроки в зависимости от разделителя
// И попросили его удалять любые лишние пробелы ( указатель в начале указан именно пробел) то сколько бы лишних пробелов при вводе не поставили наш массив их не "увидит"
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