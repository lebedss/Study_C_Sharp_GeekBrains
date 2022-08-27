// Задача
// Вывести в консоль количество нечётных элементов случайного массива с использованием библиотеки Linq


using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите массив через пробел: ");
int count = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray().Where(a => a % 2 != 0).Count();
WriteLine($"Количество нечётных элементов в этом массиве - {count}");
