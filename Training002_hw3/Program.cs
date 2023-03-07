// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend (int day)
{
    if (day > 5)
    {
        Console.WriteLine("Ура! Выходной =)");
        return true;
    }
    Console.WriteLine("Пора поработать!");
    return false;
}

bool WeekDayCheck (int day)
{
    if (day > 7 && day > 1)
    {
        Console.WriteLine("С какой Вы планеты?");
        return false;
    }
    return true;
}

Console.WriteLine("Напишите цифру дня недели ->");
int day = int.Parse(Console.ReadLine());

if (WeekDayCheck(day))
{
    Console.WriteLine(Weekend(day));    
}