using System;

namespace SortedArrays
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
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
    public static void QuickSort(int[] arr, int left, int right)
    {
      if(left < right)
      {
        int position = Partition(arr, left, right);
        QuickSort(arr, left, position - 1);
        QuickSort(arr, position + 1, right);
      }

    }
    public static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];
      int low = left - 1;
      for (int i = left; i <= right; i++ )
      {
        if(arr[i] < pivot)
        {
          low++;
          Swap(arr, i, low);
        }
      }
      arr = Swap(arr, right, low + 1);
      return low + 1;
    }
    public static int[] Swap(int [] arr, int i, int low)
    {
      int temp;
      temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
      return arr;
    }
 
  }
}

