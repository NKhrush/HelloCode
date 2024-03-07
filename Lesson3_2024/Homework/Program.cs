// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// string GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     string input = Console.ReadLine();
//     return input;
// }

// int GetDigitsSum(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// bool CheckParity(int sum)
// {
//     bool status = false;
//     if (sum % 2 == 0)
//     {
//         status = true;
//     }
//     return status;
// }

// bool BreakCheck(string input)
// {
//     bool status = false;
//     if (input == "q")
//     {
//         status = true;
//     }
//     return status;
// }

// while (true)
// {
//     string input = GetNumber("Введите число или 'q' для выхода: ");
//     if (BreakCheck(input) == true)
//     {
//         System.Console.WriteLine("STOP");
//         break;
//     }

//     int number;
//     if (int.TryParse(input, out number))
//     {
//         int sum = GetDigitsSum(number);
//         if (CheckParity(sum) == true)
//         {
//             System.Console.WriteLine("STOP");
//             break;
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
//     }
// }

// Задача 2: Задайте массив заполненный случайными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int GetArraySize(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillRandomArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(100, 1000);
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int CheckParity(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// int size = GetArraySize("Введите размер массива: ");
// int[] array = new int[size];
// FillRandomArray(array);
// PrintArray(array);
// Console.Write("Количество четных чисел в массиве: ");
// Console.WriteLine(CheckParity(array));


// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray(int size)
{
    return new int[size];
}

void FillByUser(int[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        array[index] = GetNumber("Введите " + index + " элемент: ");
        index++;
    }
}

string RevertArray(int[] array)
    {
        string result = String.Empty;
        int size = array.Length;
        int index = 0;
        int temp = 0;
        while (index < size + 1 / 2)
        {
            temp = array[index];
            array[index] = array[size - 1];
            array[size - 1] = temp;
            result = result + " " + array[index] ;
            index = index + 1;
            size = size - 1;
        }
        return result;
    }

string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }

    return result;
}


int size = GetNumber("Введите размер массива: ");
int[] numbers = CreateArray(size);
System.Console.WriteLine(Print(numbers));

FillByUser(numbers);
System.Console.WriteLine(Print(numbers));

RevertArray(numbers);
Console.WriteLine(Print(numbers));














