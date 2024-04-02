﻿// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.



int GetNumber(string text)
 {
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
 }

void PrintNumbers (int M, int N)
{
    if (M > N) return;
    Console.Write (M + " ");
    PrintNumbers (M + 1, N);
    
}

int numberOne = GetNumber("Введите значение M: ");
int numberTwo = GetNumber("Введите значение N: ");
PrintNumbers(numberOne, numberTwo);
