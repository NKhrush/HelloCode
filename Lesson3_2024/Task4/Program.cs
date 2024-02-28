// Генерация случайных чисел 

Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    Console.WriteLine("Введите целое число");
    string input = Console.ReadLine();
    arr_int[i] = rnd.Next(1, 11);
    i = i + 1;
}

i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i++;
}