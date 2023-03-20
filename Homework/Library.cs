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
// 8
    public static string SearchArgs(int number)
    {
        string result = String.Empty;
        int arg1 = number / 10000;
        int arg2 = number % 10;
        int arg3 = number / 1000 % 10;
        int arg4 = number / 100 % 10;
        if (arg1 == arg2 || arg3 == arg4)
            {
               result = result + "Это палиндром!";
               return result;
            }
         else 
            {
                result = result + "Это не палиндром :(";
                return result;
            }
    }

// 9
    public static double Distance (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
    {
        double D = Math.Pow(Math.Pow (arg4 - arg1, 2) +
                            Math.Pow (arg5 - arg2, 2) +
                            Math.Pow (arg6 - arg3, 2) , 0.5);
        System.Console.Write("Расстояние между заданными координатами в 3D пространстве = ");
        return D;
    }

//10

    public static string Cubed(int N)
    {
        int count = 0;
        int i = 1;
        string result = String.Empty;
        while (count < N)
        {
            result = result + i * i * i + " ";
            count++;
            i++;
        }
        return result;
    }








}