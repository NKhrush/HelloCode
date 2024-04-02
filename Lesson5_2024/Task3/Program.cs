// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

// ----------------- ОБЪЯВЛЕНИЕ ФУНКЦИЙ ---------

bool IsConsonant(char c)
{
return "bcdfghlmnpqrstvxzkw".Contains(c);
}

void PrintWithoutVowels(string str, int index = 0)
{
if(index >= str!.Length) return;

char c = char.ToLower(str[index]);

if(IsConsonant(c))
{
System.Console.Write(str[index] + " ");
}

PrintWithoutVowels(str, index + 1);
}
// ----------------- ОСНОВНОЙ КОД ---------------

System.Console.Write("Введите строку: ");
string? inputStr = Console.ReadLine();
PrintWithoutVowels(inputStr);