// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] array = new char[,]{
{'t', '4', '#', 'y', '9'},
{'t', '4', '#', 'y', '9'},
{'t', '4', '#', 'y', '9'},
};

string str = "";

        foreach (char item in array)
        {
            str = str + item;
        }

System.Console.WriteLine(str);