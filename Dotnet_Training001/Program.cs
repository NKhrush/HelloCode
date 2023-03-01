// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//    4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//    2 -> " -2, -1, 0, 1, 2"

// 1. Уточнения

// 2. Алгоритм

Console.WriteLine("START");
int N;
Console.WriteLine("Введите N ");
// N = int.Parse(Console.ReadLine());
// N = Convert.ToInt32(Console.ReadLine());
N = 5;

int index;
index = -N;

while (index <= N)
{
    Console.WriteLine(index);
    index = index + 1;
}

Console.WriteLine("END");