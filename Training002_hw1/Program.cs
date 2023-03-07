// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Check(int arg1)
// {
//     int a = arg1 / 10;
//     int result = a % 10;
//     return result;
// }

// int number = int.Parse(Console.ReadLine());

// Console.WriteLine(Check (number));

// Эталонное решение:

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста, повторите ввод");
    return;
}
Console.WriteLine($"Введенное число '{number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}");