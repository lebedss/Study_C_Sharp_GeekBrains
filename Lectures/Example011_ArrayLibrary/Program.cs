void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] AnotherCollection)
{
    int count = AnotherCollection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(AnotherCollection[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // -1 выдаёт когда такого элемента в массиве нет
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int RequestedResult = IndexOf(array, 4);
Console.WriteLine(RequestedResult);

// На втором семинаре преподаватель "почистил' код:

/*Имеется одномерный массив array из n элементов, требуется
найти элемент массива, равный find
Установить счетчик index в позицию 0
Если array [index] = find, алгоритм завершил работу
успешно.
Увеличить index на 1
Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно.
*/
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] collectionPrint)
// {
//     int count = collectionPrint.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(collectionPrint[position] + " ");
//         position++;
//     }
//     Console.WriteLine();
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int position = -1;//убираем 1 элемент/-1 это значит элемент не найден!
//     for (int index = 0; index < count; index++)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//     }
//     return position;
// }
// int searchableValue = 4;
// int arraySize = 10;

// int[] array = new int[arraySize];
// //тестируем массив
// FillArray(array);
// PrintArray(array);
// int pos = IndexOf(array, searchableValue);//ищем 4 меняется значение(Можно прикрутить ввод с клавиатуры)
// Console.WriteLine($"Позиция {searchableValue} {pos}");