
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

// создание нового массива
string[] newArray = new string[newArrayLength];
newArrayLength = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        newArray[newArrayLength] = input[i];
        newArrayLength++;
    }
}

Console.WriteLine();
foreach (string s in newArray)
{
    Console.Write(s + " ");
}

