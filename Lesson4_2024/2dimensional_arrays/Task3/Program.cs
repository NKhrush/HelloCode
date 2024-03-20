// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состаящую из букв исходной строки. 

// 123passw0rd

string GetLettersFromString (string s)
{
    string letters  = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);