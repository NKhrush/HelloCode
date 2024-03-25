// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

System.Console.WriteLine("Введите срочку");
string userInput = Console.ReadLine();

string vowels = "aeiuo";
int count= 0;

foreach (var item in userInput)
{
if(vowels.Contains(item))
{
count++;
}
}
System.Console.WriteLine(count);