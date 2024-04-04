// Задача 3: Задайте произвольный массив. Выведите его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] CreateArray(int size)
{
    return new int[size];
}

void FillRandomArray(int[] collection, int index = 0)
{
    
    if (index == collection.Length) return;
    
        collection[index] = new Random().Next(1, 10);
        index++;
        FillRandomArray(collection, index);
    
}

void PrintArray(int[] array, int index = 0)
{

    if (index == array.Length) return;
   
        Console.Write(array[index++] + " ");
        PrintArray(array, index);
    
}

void PrintArrayBackwards(int[] array, int index)
{

    if (index == 0) return;
    
        Console.Write(array[index-1] + " ");
        index = index - 1;
        PrintArrayBackwards(array, index);
    
}

int[] array = CreateArray(5);
FillRandomArray(array);
PrintArray(array);
Console.WriteLine();
PrintArrayBackwards(array, array.Length);