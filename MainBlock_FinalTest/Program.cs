string [] CreateArray(int size)
    {
        return new string [size];
    }

void FillByUser(string[] array)
    {
        int size = array.Length;

        int index = 0;

        while (index < size)
        {
            array[index] = GetSymbol("Введите " + index + " элемент: ");
            index++;
        }
    }

string GetSymbol (string text)
    {
        System.Console.WriteLine(text);
        return Console.ReadLine();
    }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Console.WriteLine ("Введите размер массива: ");
int str =  Convert.ToInt32 (Console.ReadLine());
string [] array = CreateArray (str);
FillByUser(array);
Console.WriteLine ("Первоначальный массив: ");
PrintArray(array);
