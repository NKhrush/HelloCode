//Массивы


int[] array = new int[9];
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string isFind = "Нет";
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 17);
    System.Console.Write(array[i] + " ");

    if(num == array[i])
    {
        isFind = "Да";
    }
}
Console.WriteLine(isFind);