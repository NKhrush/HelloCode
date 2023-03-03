// 4. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//     3 -> Среда 
//     5 -> Пятница

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
if (day >= 1 &&  day <= 7)
{
    Console.WriteLine(days[day - 1]);
}
else
{
    Console.WriteLine("Нет такого дня");
}
// if (number < 1 || number > 7) Console.WriteLine("Вы с другой планеты?");
// if (number == 1) Console.WriteLine("Понедельник");
// if (number == 2) Console.WriteLine("Вторник");
// if (number == 3) Console.WriteLine("Среда");
// if (number == 4) Console.WriteLine("Четверг");
// if (number == 5) Console.WriteLine("Пятница");
// if (number == 6) Console.WriteLine("Суббота");
// if (number == 7) Console.WriteLine("Воскресенье");
