// Задача 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1   1 2 3 5 8
// Определение Фибоначчи - это последовательность цифр где F0 = 0, F1 = 1, Fn = Fn-2 + Fn-1, n >=2

using static System.Console;
Clear();
Write("Введите N-ое количество чисел Фибоначчи которое вы хотите получить: ");
WriteLine($"Первые N чисел Фибоначчи: {String.Join(",", PrintSpecificAmountOfFibanacciNumbers(int.Parse(ReadLine()!)))}");

int[] PrintSpecificAmountOfFibanacciNumbers(int number)
{
    int[] result = new int[number];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 2] + result[i - 1];
    }
    return result;
}

