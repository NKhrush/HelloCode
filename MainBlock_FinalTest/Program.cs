
Console.WriteLine("Введите строки через пробел:");
string[] input = Console.ReadLine().Split(' ');

int newArrayLength = 0; // длина нового массива
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        newArrayLength++;
    }
}