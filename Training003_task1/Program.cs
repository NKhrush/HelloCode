using static Library;

Math
// Показать четные числа от 1 до N
// 1. считать данные от пользователя
// 2.  сформировать строку из четных чисел

// string EvenNumbers(int N)
// {
//     string output = "";
//     int index = 2;
//     while (index <= N)
//     {
//         output = output + index + " ";
//         index = index + 2;
//     }
//     return output;
// }

// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int N = GetNumber("Введите число ");
// string result = EvenNumbers(N);
// Console.WriteLine(result);
// File.WriteAllText("file.txt", result);

// Задача 2
// Реализовать перемешивание массива
// 1. создание массива

// 2. ввод числа

// 3. печать массива



int size = GetNumber("Введите размер массива ");
int[] numbers = CreateArray(size);
System.Console.WriteLine(Print(numbers));

FillByUser(numbers);
System.Console.WriteLine(Print(numbers));

// int[] mas = GetMix(numbers);
// System.Console.WriteLine(Print(numbers));

// 4. запонение массива
// 4.1 руками


// 4.2 случайно

// 5. перемешивание массива

 