// // 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// // 456 -> 46
// // 782 -> 72
// // 918 -> 98

// //---
// // abc = a * 100 + b * 10 + c = a * 10^2 + b * 10^1 + c * 10^0
// // --
// //ac = a * 10 + c

// int value = 789;

// int a = value / 100;
// int c = value % 10;

// // Console.WriteLine(-13 % 4);

// -13 mod 4 =>

// a = b * p + q   0 <= q < b
// -13 = 4*(-4) + 3

// 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number;

// number = new Random().Next (10,99);
// Console.WriteLine(number);

// int number1 = number div 10;
// int number2 = number / 1;

// if (number1 > number2)
// {
//     Console.WriteLine(number1);
// }
// else
// {
//     Console.WriteLine(number2);
// }

// 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
//***
// 3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// double number1;
// double number2;

// number1 = double.Parse(Console.ReadLine());
// number2 = double.Parse(Console.ReadLine());

// if (number1 % number2 == 0)
// {
// Console.WriteLine("ДА");
// }
// else
// {
//     Console.WriteLine("НЕТ");
// }

bool Check(double arg1, double arg2)
{
    return arg1 % arg2 == 0;
}

Console.Write("a = ");
string a = Console.ReadLine();
double d1 = Convert.ToDouble(a);

Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Check(d1, b));

if (arg1 % arg2 != 0) 
{
    int remain = arg1 % arg2;
    Console.WriteLine(remain);
}

//***
// 4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// OPTION 1!!!!

// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(number % 7 == 0 && number % 23 == 0);

// OPTION 2:

// bool Check(int number)
// {
//     return number % 7 == 0 && number % 23 == 0;
// }

// Console.Write("a = ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Check (a));

// ***
// 5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// bool Check(int arg1, int arg2)
// {
//     return arg2 / arg1 == arg1 | arg1 / arg2 == arg2;
// }

// int number1 = 8;
// int number2 = 9;

// Console.WriteLine(Check(number1,number2));
