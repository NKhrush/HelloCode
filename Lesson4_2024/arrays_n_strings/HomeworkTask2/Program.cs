// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("Введите строчку: ");
string userInput = Console.ReadLine();

System.Text.StringBuilder str = new System.Text.StringBuilder(userInput);
        
for (int j = 0; j < str.Length; j++)
{
    if (System.Char.IsUpper(str[j]) == true)
        str[j] = System.Char.ToLower(str[j]);
}
Console.Write (str);