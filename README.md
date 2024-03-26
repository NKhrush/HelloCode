# Урок 1. Знакомство с языком программирования С# 
## (Семинар)
### Задачи:

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
## (Семинар)

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

### ___Домашка!___
### Урок 2. Базовые алгоритмы
Можно вместо ввода с клавиатуры использовать Random

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
[Решение](Training002_hw1/Program.cs)

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
[Решение](Training002_hw2/Program.cs)


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

[Решение](Training002_hw3/Program.cs)

# Урок 3. Функции: продолжение
## (Лекция) 

Упорядочение массива [Решение](Lesson003_array/Program.cs)

# Урок 3. Базовые алгоритмы. Продолжение
## (Семинар)

Задача 1.
Показать четные числа от 1 до N 

Задача 2
Реализовать перемешивание массива
[Решение](Training003_task1/Program.cs)

### ___Домашка!___
## Урок 3. Базовые алгоритмы. Продолжение
[Решения_задач](Homework/Program.cs)

Задача 2
Дан массив: наполнени числами от 1 до N
Задача: сколько раз какое число встречается

1 3 1 2 1 2 4 5 1 2 5 4

1 - 4р
2 - 3р
3 - 1р
4 - 2р
5 - 2р


Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
[Решение](Homework/Program.cs)


Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

### ___Домашка!___
## Урок 4. Функции

Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
нельзя использовать Math.Pow
3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


Задача 1: Задайте массив из N случайных числел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и 
делатся нацело на 7.
Пример 

[1 5 11 21 4 0 91 2 3 ]
=>2

[Решение](Lesson4_2024\Task1)

Урок 4. Функции
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Задача 2: Задайте массив заполненный случайными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)

[Решение трех задач](Lesson3_Homework)


Урок 5. Двумерные массивы
Задача 1: Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
Пример
2 3 4 3
4 3 4 1 =>
2 9 5 4
Обсудить этапы решения задачи
Оформить этапы в виде функций
4 3 16 3
4 3 4 1
4 9 25 4

[Решение](Lesson4_2024/2dimensional_arrays/Task4)

Задача 2:находящихся на главной диагонали с индексами (0,0); (1;1) и
т.д.
Пример
2 3 4 3
4 3 4 1 => 2 + 3 + 5 = 10
2 9 5 4

[Решение](Lesson4_2024/2dimensional_arrays/Task5)

Задача 6: Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4

[Решение](Lesson4_2024/2dimensional_arrays/Task6)

Массивы и строчки
Задача 1: Задайте массив символов (тип char []). Создайте строку из
символов этого массива.

[Решение](Lesson4_2024/arrays&strings/Task1)

Задача 3: 
На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран
[Решение](Lesson4_2024/arrays_n_strings/Task3)