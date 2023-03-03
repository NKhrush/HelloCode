int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {11, 21, 31, 41, 51, 61, 71, 81, 91};
array[0] = 12; // таким образом можно обратиться к массиву и записать в него значение
Console.WriteLine(array[0]); // таким образом можно обратиться к массиву и получить значение соответствующего элемента по указанному индексу
