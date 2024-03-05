// Задача 1: Задайте массив из N случайных числел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и 
// делатся нацело на 7.
// Пример 
// [1 5 11 21 4 0 91 2 3 ]
// =>2

// Создать функцию: тип возвращающего значения / void + название + ()+ {}
// Вызвать функцию: Название + ()

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(20, 24);
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


int GetCountNumber()
{
int count=0;

for (int i = 0; i < array.Length; i++)
{
if(array[i]%7==0 && array[i]%10==1) // и &&
{
count= count+1;
// count++;
}
}
return count;
}

FillingArray();
PrintArray();
System.Console.WriteLine(GetCountNumber());