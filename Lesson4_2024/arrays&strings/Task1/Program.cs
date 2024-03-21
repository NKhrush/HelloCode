// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

char[] array = new char[]{'t', '4', '#', 'y', '9'};

string str ="";

// for (int i = 0; i < array.Length; i++)
// {
// str = str + array[i];
// }
// System.Console.WriteLine(str);

foreach (char item in array)
{
str = str + item;
}

System.Console.WriteLine(str);