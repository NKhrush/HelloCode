


int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //запрашиваем колво строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //запрашиваем колва столбцов (1е измерение)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //запрашиваем колво строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //запрашиваем колва столбцов (1е измерение)
        {
            Console.Write($"{matrix[i, j]} "); //интерполяция строк
        }
        Console.WriteLine();
    }

}

int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);