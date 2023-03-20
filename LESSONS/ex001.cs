public class ex001
{
    public static void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }


    public static void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,10); //[1;10]
            }
        }
    }


   public static void PrintImage(int[,] image)
      {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++)
            {
                //Console.Write($"{matr[i, j]} ");
                if (image[i,j] == 0) Console.Write($" ");
                else Console.Write($"+");
            }
            Console.WriteLine();
        }
    }
    
//     public static void FillImage(int row, int col)
//     {
//         if (pic[row, col] == 0)
//         {
//             pic[row, col] = 1;
//             FillImage(row-1, col);
//             FillImage(row, col-1);
//             FillImage(row+1, col);
//             FillImage(row, col+1);
//         }
//     }

}
