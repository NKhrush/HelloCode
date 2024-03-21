// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4



/ Печать массива
    public static void PrintArray(int[,] array)
{
    //Напишите свое решение здесь
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
public static int[,] SwapFirstLastRows(int[,] array)
{
    //Напишите свое решение здесь
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SwapItems(array, i);
    }
    return array;
}

// Обмен элементами массива
public static void SwapItems(int[,] array, int i)
{
    //Напишите свое решение здесь
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}
public static void PrintResult(int[,] numbers)
{
    //Напишите свое решение здесь
    PrintArray(SwapFirstLastRows(numbers));
}
}

