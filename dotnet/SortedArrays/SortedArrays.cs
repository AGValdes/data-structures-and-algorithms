using System;

namespace SortedArray
{
  public class Program
  {
    static void Main(string[] args)
    {
      
    }

    public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                while (j >= 0 && temp < array[j])
                {
                   array[j + 1] = array[j];
                   j = j - 1;
                }
            array[j + 1] = temp;

            }
            return array;
        }
  }
}
