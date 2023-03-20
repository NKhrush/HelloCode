public class Library
{

// 1. создание массива
    public static int [] CreateArray(int size)
    {
        return new int[size];
    }

// 2. рандомное заполнение массива
    public static void FillRandomArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
           collection[index] = new Random().Next(1, 10);
           index++;
        }
    }

// 3. ввод размера массива
    public static int GetArraySize(string text)
    {
        System.Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    // рандомное заполнение массива


// 4. печать массива
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

// 5. запонение массива руками

    public static void FillByUser(int[] array)
    {
        int size = array.Length;

        int index = 0;

        while (index < size)
        {
            array[index] = GetNumber("Введите " + index + " элемент: ");
            index++;
        }
    }


// 6. перемешивание массива
    public static string GetMixedArray(int[] array)
    {
        string result = String.Empty;
        int size = array.Length;
        int index = 0;
        int temp = 0;
        while (index < size + 1 / 2)
        {
            temp = array[index];
            array[index] = array[size - 1];
            array[size - 1] = temp;
            result = result + " " + array[index];
            index = index + 2;
            size = size - 1;
        }
        return result;
    }


// 7. 
    public static int GetNumber (string text)
    {
        System.Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
}