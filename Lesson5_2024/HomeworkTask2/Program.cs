// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;

    else if (n == 0) return Ackermann(m - 1, 1);

    else return Ackermann(m - 1, Ackermann(m, n - 1));
}


int numberOne = GetNumber("Введите значение m: ");
int numberTwo = GetNumber("Введите значение n: ");
int result = Ackermann(numberOne, numberTwo);
Console.Write("Решение: " + result);
