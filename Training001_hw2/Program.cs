﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a;
int b;
int c;
int max;
Console.WriteLine("Введите a ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c ");
c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
} 
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
         max = c;
    }
}

Console.WriteLine(max);