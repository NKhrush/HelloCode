// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

int[,] array = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

// int x = 2;
// int y = 2;
// Выводится: 6


// // создание массива
// // вывод массива
// // запрос на введение x y
// // ввод индексов
// // проверка
// // вывод значения массива или ошибки


// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int GetX(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int GetY(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // bool CheckX(int X)
// // {
// //     bool status = true;
// //     int IndexX = X - 1;
// //     if (IndexX < 0 || IndexX > array.GetLength(0)) // 0 1 2    x = 3 
// //     {
// //         status = false;
// //     }
// //     return status;
// // }


// bool CheckXY(int[,] array, int x, int y)
// {
//     int IndexX = x - 1;
//     int IndexY = y - 1;
//     int status = true;

//     if (IndexX < 0 || IndexX > array.GetLength(0))
//     {
//         status = false;
//         Console.WriteLine("Позиция по рядам выходит за пределы массива");
//     }
//     esle status = true;

//     if (IndexY < 0 || IndexY > array.GetLength(1))
//     {
//         status = false;
//         Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//     }
//     else status = true;
//     return status;
// }

// int GetArrayNumber(int X, int Y)
// {
//     int result = array[X - 1, Y - 1];

//     return result;
// }

// void Check(int X, int Y)
// {
//     if (CheckX(X) == true)
//     {
//         if (CheckY(Y) == true)
//         {
//             Console.WriteLine(GetArrayNumber(X, Y));
//         }
//         else Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//     }
//     else Console.WriteLine("Позиция по рядам выходит за пределы массива");
// }

// PrintArray();
// int X = GetX("Введите X: ");
// int Y = GetY("Введите Y: ");
// Check(X, Y);


int FindElementByPosition(int[,] array, int x, int y)
    {
        return array[x - 1, y - 1];
    }

// Проверка позиций на вхождение в массив
    bool ValidatePosition(int[,] array, int x, int y)
    {
        if (x <= 0 || x >= array.GetLength(0)) {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return false;
        }
        if (y <= 0 || y >= array.GetLength(1)) {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return false;
        }
        return true;
    }

    void PrintResult(int[,] numbers, int x, int y)
    {
        if (ValidatePosition(numbers, x, y)) {

Console.WriteLine(FindElementByPosition(numbers, x, y));
        }
    }

PrintResult(array, 2, 2);