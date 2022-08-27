// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Треугольник существует только тогда, когда сумма любых двух его сторон больше третьей. 
// Требуется сравнить каждую сторону с суммой двух других. Если хотя бы в одном случае сторона окажется больше или равна сумме двух других, то треугольника с такими сторонами не существует.".
// a + b > c && b + c > a && a + c > b где a,b,c  стороны треугольника
// Однако не стоит забывать что пользователь должен ввести 3 стороны и в случае ошибки ввода данных треугольник с количеством сторон > 3 - не существует...

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите три числа через пробел чтобы проверить может ли существовать треугольник с сторонами такой длины: ");
int[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
// WriteLine(TriangleExistencePossibilityChecking(array));
WriteLine(TriangleExistencePossibilityChecking(array) ? "Да, такой треугольник существует" : "Нет, такой треугольник не существует");


// string TriangleExistencePossibilityChecking(int[] anyArray)
// {
//     string message = String.Empty;
//     if (anyArray.Length == 3)
//     {
//         for (int i = 0; i < anyArray.Length ; i++)
//         {
//             message = anyArray[0] + anyArray[1] > anyArray[2] ? $"Стороны: {String.Join(" ", anyArray)} - такой треугольник существует!" : message;
//             message = anyArray[1] + anyArray[2] > anyArray[0] ? $"Стороны: {String.Join(" ", anyArray)} - такой треугольник существует!" : message;
//             message = anyArray[2] + anyArray[0] > anyArray[1] ? $"Стороны: {String.Join(" ", anyArray)} - такой треугольник существует!" : $"Стороны: {String.Join(" ", anyArray)} - такой треугольник не существует!";
//         }
//     }
//     Write("У треугольника должно быть три стороны. ");
//     return message;
// }


// Оптимальное решение через метод bool

bool TriangleExistencePossibilityChecking(int[] anyArray)
{
    if (anyArray.Length == 3)
    {
        return ((anyArray[0] + anyArray[1] > anyArray[2]) && (anyArray[1] + anyArray[2] > anyArray[0]) && (anyArray[2] + anyArray[0] > anyArray[1]));
    }
    Write("У треугольника должно быть три стороны... ");
    return false;
}
