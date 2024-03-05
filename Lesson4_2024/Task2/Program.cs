// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10);
}
}

void PrintArray()
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i]+ " ");
}
System.Console.WriteLine();
}


int GetNumber()
{
string num = "";

for (int i = 0; i < array.Length; i++)
{
num = num + array[i];
}
return Convert.ToInt32(num);
}

FillingArray();
PrintArray();
System.Console.WriteLine(GetNumber());