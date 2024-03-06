// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



string GetNumber(string text)
{
    System.Console.WriteLine(text);
    string input = Console.ReadLine();
    return input;
}

int GetDigitsSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

bool CheckParity(int sum)
{
    bool status = false;
    if (sum % 2 == 0)
    {
        status = true;
    }
    return status;
}

bool BreakCheck(string input)
{
    bool status = false;
    if (input == "q")
    {
        status = true;
    }
    return status;
}

while (true)
{
    string input = GetNumber("Введите число или 'q' для выхода: ");
    if (BreakCheck(input) == true)
    {
        System.Console.WriteLine("STOP");
        break;
    }

    int number;
    if (int.TryParse(input, out number))
    {
        int sum = GetDigitsSum(number);
        if (CheckParity(sum) == true)
        {
            System.Console.WriteLine("STOP");
            break;
        }
    }
    else 
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}



// /


// while (true) // Бесконечный цикл
// {
//     Console.Write("Введите число или 'q' для выхода: ");
//     string input = Console.ReadLine(); // Чтение строки ввода пользователя
//     if (input == "q") // Проверка на ввод 'q' для выхода
//     {
//         break;
//     }
//     int number;
//     if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
//     {
//         int sum = 0;

//         while (number > 0) // Вычисление суммы цифр числа
//         {
//             sum += number % 10; // Добавление последней цифры к сумме
//             number /= 10; // Удаление последней цифры из числа
//         }
//         if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//     }
//     else // Если ввод не является числом и не 'q', повторить запрос
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//     }
// }