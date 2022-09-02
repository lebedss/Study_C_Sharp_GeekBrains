// // Собрать строку с числами от a до b, a ≤ b

// string NumbersFor(int a, int b)
// {
// string result = String.Empty;
// for (int i = a; i <= b; i++)
// {
// result += $"{i} ";
// }
// return result;
// }

// string NumbersRec(int a, int b)
// {
// if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
// else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// // Сумма чисел от 1 до n
// int SumFor(int n)
// {
// int result = 0;
// for (int i = 1; i <= n; i++) result += i;
// return result;
// }

// int SumRec(int n)
// {
// if (n == 0) return 0;
// else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55


// // Факториал числа
// int FactorialFor(int n)
// {
// int result = 1;
// for (int i = 1; i <= n; i++) result *= i;
// return result;
// }

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800


// // Вычислить а в степени n
// int PowerFor(int a, int n)
// { int result = 1;
// for (int i = 1; i <= n; i++) result *= a;
// return result;
// }

// int PowerRec(int a, int n)
// { //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
// if (n == 0) return 1;
// else return PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024


// // Перебор слов.
// // В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// // Покажите все слова, состоящие из T букв, которые можно построить из букв этого алфавита

// // Чем больше букв в слове тем больше циклов надо добавить:
// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
// Console.WriteLine($"{n++,-5}{s[i]}");
// }

// // Общее решение(рекурсия)
// void FindWords(string alphabet, char[] word, int length = 0)
// {
// if (length == word.Length)
// {
// Console.WriteLine($"{n++} {new String(word)}"); return;
// }
// for (int i = 0; i < alphabet.Length; i++)
// {
// word[length] = alphabet[i];
// FindWords(alphabet, word, length + 1);
// }
// }
// FindWords("аисв", new char[5]);

// Как посмотреть содержимое папки?

void CatalogInfo(string path, string indent = "")
{
DirectoryInfo catalogs = new DirectoryInfo(path);
foreach (var currentCatalog in catalogs.GetDirectories())
{
Console.WriteLine($"{indent}{currentCatalog.Name}");
CatalogInfo(currentCatalog.FullName, indent + " ");
}
foreach (var item in catalogs.GetFiles())
{
Console.WriteLine($"{indent}{item.Name}");
}
}
string path = @"D:\STUDY\StudyGeekBrains\My_projects\Study_C_sharp\Lectures\Example001_HelloConsole";
CatalogInfo(path);