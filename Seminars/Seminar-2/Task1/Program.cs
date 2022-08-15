/*
Задача 9. Напишите программу, которая выводит случайное число из отрезка 
[10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/
int GetRandomNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}
int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int secondDigit = number % 10;
    if (secondDigit > result)
    {
        result = secondDigit;
    }
    return result;
}

int randomNumber = GetRandomNumberInRange(10, 99);

int maxDigit = GetMaxDigitFromNumber(randomNumber);

Console.WriteLine($"Наибольшая цифра числа {randomNumber} является {maxDigit}");