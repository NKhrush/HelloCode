// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1


/// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        int[] sum = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[i] += array[i, j];
            }
        }
        return sum;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        int minI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[minI] > array[i])
            {
                minI = i;
            }
        }
        return minI;
    }
    public static void PrintResult(int[,] numbers)
    {   
        int[] sums = SumRows(numbers);
        int minIndex = MinIndex(sums);
        Console.Write(minIndex);
    }
