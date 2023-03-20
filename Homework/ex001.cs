public class ex001
{
// 3. посчитать сколько раз в массиве встречается каждый элемент массива

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

}