using static System.Console;
Clear();

// Вывод массива из строки:
// int[] array = new int[3];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(ReadLine());
// }
// WriteLine($"[{String.Join(", ", array)}]");

//  Когда мы вручную заполняем наш массив через консоль если мы ставим лишний символ включая пробел( пустое пространство) компилятор воспринимает его как элемент массива
//  Чтобы этого избежать используем  метод Split.RemoveEmptyEntries

// string[] arrayString = ReadLine().Split(new char[] { ' ', '#', ',' }, StringSplitOptions.RemoveEmptyEntries);
// int[] array = new int[arrayString.Length];
// for (int i = 0; i < arrayString.Length; i++)
// {
//     array[i] = int.Parse(arrayString[i]);
// }
// WriteLine($"[{String.Join(",", array)}]");


//  Сделали метод (передаём на вход строку - возвращаем массив из чисел)
int[] array = GetArrayFromString(ReadLine()!);
WriteLine($"[{String.Join(",", array)}]");

int[] GetArrayFromString(string arrayString)
{
    string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[massString.Length];
for(int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(massString[i]);
}
return result;
}