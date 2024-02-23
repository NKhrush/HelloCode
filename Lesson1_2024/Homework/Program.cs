// Задача 1:  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else Console.WriteLine("не кратно");


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Введите X: ");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X == 0)
// {
//     Console.WriteLine("неверное значение X");
// }
// if (Y == 0)
// {
//      Console.WriteLine("неверное значение Y");
// }
// else 
//     if (X > 0 && Y > 0)
//         {
//             Console.WriteLine("I координатная четверть");
//         }
//         if (X < 0 && Y < 0)
//         {
//             Console.WriteLine("III координатная четверть");
//         }
//         if (X > 0 && Y < 0)
//         {
//             Console.WriteLine("IV координатная четверть");
//         }
//         if (X < 0 && Y > 0)
//         {
//             Console.WriteLine("II координатная четверть");
//         }



// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int a = num / 10;
// int b = num % 10;
// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else Console.WriteLine(b);

// // Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите натурально число: "); 
// String num = Console.ReadLine(); 
 
// for (int i = 0; i< num.Length; i++) 
// { 
// Console.Write(num[i]+", "); 
// }