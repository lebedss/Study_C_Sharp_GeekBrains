//  1 Вид методов
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//  2 Вид методов
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения"); //  Явно указываем какому аргументу какое значение хотим указать, может потребоваться когда  несколько аргументов используем

// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method2_1(msg: "Текст ", count: 4);
// Method2_1(count: 4,  msg: "Новый текст");

//  3-ий вид методов

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//  4-ий вид методов
// string Method4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i < count)
// {
//     result += text;
//     i++;
// }
// return result;
// }
// string FinalResult = Method4(10, "Вах");
// Console.WriteLine(FinalResult);

//  4-ий вид методов + цикл for
// string Method4_via_FOR(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result += text;
//     }
//     return result;
// }
// string FinalResult = Method4_via_FOR(10, "Вах");
// Console.WriteLine(FinalResult);

// Цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// Ясна ли задача?

// string text = " – Я думаю, – сказал князь, улыбаясь, – что, "
//                  + "ежели бы вас послали вместо нашего милого Винценгероде,"
//                  + "вы бы взяли приступом согласие прусского короля. "
//                  + "Вы так красноречивы. Вы дадите мне чаю?";
// //  string s = "qwerty"
//                    012345
//  s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string NewText = Replace(text, ' ', '|');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'к', 'К');
// Console.WriteLine(NewText);
// NewText = Replace(NewText, 'с', 'С');
// Console.WriteLine(NewText);

//  Задача - упорядочить массив от минимального элемента к максимальному
// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin_to_Max(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortMin_to_Max(arr);

PrintArray(arr);