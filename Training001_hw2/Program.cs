// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



int Max(int number1, int number2, int number3)
{
    int result = number1;
    if (number2 > result) result = number2;
    if (number3 > result) result = number3;
    return result;
}

int number1;
int number2;
int number3;

Console.WriteLine("Введите число 1 ");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
number3 = int.Parse(Console.ReadLine());

int result = Max(number1, number2, number3);

Console.WriteLine(result);
