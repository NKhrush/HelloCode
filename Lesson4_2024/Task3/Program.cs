// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 3 // 19 2 3 4 5 6 18
// [4 3 4 1 9 5 21 13] => 3 // 21 2 3

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 30);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int GetNumber()
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool isFind = true;

        for (int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                isFind = false;
            }
        }

        if (isFind == true)
        {
            count = count + 1;
        }
    }
    return count;
}

FillingArray();
PrintArray();
System.Console.WriteLine(GetNumber());