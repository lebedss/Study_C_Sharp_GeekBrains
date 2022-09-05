// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//  строка + столбец + глубина
// 1-мерный массив - строчка на листе
// 2-мерный массив - несколько строк на листе
// 3-мерный массив - целая тетрадь
// 4-мерный массив - несколько тетрадей 
// 5-мерный массив - полки с тетрадями
// 6-мерный массив - несколько шкафов где находятся полки с тетрадями
// 7-мерный массив - комнаты со шкафами
// 8-мерный массив - несколько этажей в здании где находятся комнаты со шкафами
// 9-мерный массив - несколько зданий
// 10-мерный массив - районы города с зданиями
// 11-мерный массив - несколько городов
// 12-мерный массив - области с городами
// 13-мерный массив - страны
// 14-мерный массив - союзы стран
// 15-мерный массив - континенты
// 16-мерный массив - планеты
// 17-мерный массив - звездные системы
// 18-мерный массив - галактики
// 19-мерный массив - скопление галактик
// 20-мерный массив - вселенная
// 21-мерный массив -мультивселенная

using static System.Console;
using System.Linq;
Clear();
Write("Введите размеры трёхмерного массива через пробел: ");
int[] sizes = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,,] array = Get3DRandomArray(new int[] {sizes[0], sizes[1], sizes[2]});
Print3DArray(array);


int[,,] Get3DRandomArray(int[] anySizes)
{
    int[,,] resultArray = new int[anySizes[0], anySizes[1], anySizes[2]];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int k = 0;
            while (k < resultArray.GetLength(2))
            {
                int element = new Random().Next(10, 100);
                if (CheckIfRandomElementIsNotDuplicate(resultArray, element))continue; //Оператор continue осуществляет принудительный переход к следующему шагу цикла, пропуская любой код, оставшийся невыполненным.
                resultArray[i, j, k] = element;
                k++;
            }
        }
    }
    return resultArray;
}


bool CheckIfRandomElementIsNotDuplicate(int[,,] myArray, int item)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                if (myArray[i, j, k] == item) return true;
            }
        }
    }
    return false;
}


void Print3DArray(int[,,] newArray)
{
    WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел: значение элемента (строка, cтолбец, глубина):");
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                Write($"{newArray[i, j, k]} ({j},{k},{i}) ");
            }
            WriteLine();
        }
    }
}
