// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

int GetNumber (string text)
    {
        System.Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

 string SearchArgs(int number)
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


int number = GetNumber("Введите пятизначное число ");
Console.WriteLine (SearchArgs(number));