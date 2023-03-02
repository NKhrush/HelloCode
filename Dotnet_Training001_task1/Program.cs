// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//     456 -> 5
//     782 -> 8
//     918 -> 1

// && логическое AND
// OR ||
// ! NOT
// ^ XOR истинно тогда, когда только одна из операций истинна

int value = 100;
if (value > 99 && value < 1000)
{
// 456 -> 45 -> 5
int result = (value / 10) % 10;
Console.WriteLine (result);
// 456 -> 56 -> 5
result = (value % 100) / 10;
Console.WriteLine (result);
// 456 -> 45 -> 45 - 4 * 10
result = (value / 10) - ((value / 10) / 10 * 10);
Console.WriteLine (result);
}
else
{
    Console.WriteLine("Число кривое");
}

// ***
// int value = 1234567;
// while (value != 0)
// {
//     Console.WriteLine(value % 10);
//     value = value / 10;
//     }
// ***

// 14 / 5 = 2.8
// Console.WriteLine (14.0/5.0);
// Console.WriteLine (14.0/5);
// Console.WriteLine (14/5.0);
// // 14 div 5 = 2
// Console.WriteLine (14/5);
// // 14 mod 5 = 4
// Console.WriteLine (14%5);

