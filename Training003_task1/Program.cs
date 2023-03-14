// Покахать четные числа от 1 до N


string EvenNumbers(int N)
{
    string output = "";
    int index = 2;
    while (index <= N)
    {
        output = output + index + " ";
        index = index + 2;
    }
    return output;
}

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetNumber("Введите число ");
string result = EvenNumbers(N);
Console.WriteLine(result);
File.WriteAllText("file.txt", result);