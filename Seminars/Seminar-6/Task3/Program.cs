// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Десятичное число - это число, которое используется в десятичной системе счисления. 
// Как нетрудно догадаться, существует 10 различных цифр(от 0 до 9), используемых для составления десятичных чисел (они также известны как арабские):
// Алгоритм перевода из десятичной системы в двоичную :
// Последовательно выполнять деление десятичного числа и получаемых целых частных на 2, до тех пор, пока частное не станет равным 0.
// Для получения ответа в двоичном коде, необходимо записать, полученные, в результате деления остатки, в обратном порядке.


// using static System.Console;
// Clear();

// Write("Введите число которое хотите преобразовывать из десятичного в двоичное: ");
// Write(NumbersConvertorDecimalToBinary(int.Parse(ReadLine()!)));


// string NumbersConvertorDecimalToBinary(int number)
// {
//     string result = String.Empty;
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         number /= 2;
//     }

//     return result;
// }

// Напишите программу, которая будет преобразовывать десятичное число в восьмеричную систему

using static System.Console;
using System.Linq;
Clear();
Write("Введите число:");
// WriteLine(Convert.ToString(int.Parse(ReadLine()!), 8)); //  Такая конвертация работает до 16-ой системы
// WriteLine(GetNum(int.Parse(ReadLine()!)));
WriteLine(DecToNum(int.Parse(ReadLine()!), 2));

//  Такая конвертация также работает до 16-ой системы

// string GetNum(int number)
// {
//     string result = "";

//     while (number > 0)
//     {
//         result = number % 8 + result;
//         number /= 8;
//     }
//     return result;
// }


//  Универсальный метод для любой системы исчисления:
//  Любая строка может быть рассмотрена как массив символов - здесь мы пользуемся этим свойством
//  В системах начиная  с 16-ой используются буквы ( A =10 ; B=11 ; C=12 и т д)
//  Хоть мы и получаем на вход числа, но по факту работаем с строками и символами. Числа нужны лишь чтобы определить индекс

        string DecToNum(int OriginNumber, int OtherSystemValue)
        {
            string MyResult =  String.Empty;
            string CharArrayOfPossibleSymbols = "0123456789ABCDEF";
            while (OriginNumber > 0)
            {
                int LeftOver = OriginNumber % OtherSystemValue;
                MyResult = CharArrayOfPossibleSymbols[LeftOver] + MyResult; // здесь используется конкатенация строк  string s1 = "hello"; string s2 = "world"; string s3 = s1 + " " + s2;  -  результат: строка "hello world"
                OriginNumber /= OtherSystemValue;
            }
            return MyResult;
        }
