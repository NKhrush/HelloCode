# Урок 1. Знакомство с языком программирования С# 
## Задачи:

1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
    [Решение](Dotnet_Training001_task1/Program.cs)


2. Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
    4 -> 16 
    -3 -> 9 
    -7 -> 49
    [Решение](Dotnet_Training001_task2/Program.cs)



3. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
    a = 25, b = 5 -> да 
    a = 2, b = 10 -> нет 
    a = 9, b = -3 -> да 
    a = -3 b = 9 -> нет
[Решение](Dotnet_Training001_task3/Program.cs)


4. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
    3 -> Среда 
    5 -> Пятница
[Решение](Dotnet_Training001_task4/Program.cs)


5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
    4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
    2 -> " -2, -1, 0, 1, 2"
[Решение](Dotnet_Training001_task5/Program.cs)

### ___Домашка!___
### ___Урок 1. Знакомство с языком программирования С#___

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
[Решение](Training001_HW1/Program.cs)

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
[Решение](Training001_hw2/Program.cs)

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
[Решение](Training001_hw3/Program.cs) 

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
[Решение](Training001_hw4/Program.cs)

# Урок 2. Базовые алгоритмы

[Решение всех задач по уроку](Training002_TASKS/Program.cs)
1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8

2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да


5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
