public class Library
{

// 1. создание массива
public static int [] CreateArray(int size)
{
    return new int[size];
}
// 2. ввод числа
public static int GetNumber(string text)
 {
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
 }

// 3. печать массива
public static string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }

    return result;
}

public static void FillByUser(int[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        array[index] = GetNumber("Введите " + index + " эдемент: ");
        index++;
    }
}
}