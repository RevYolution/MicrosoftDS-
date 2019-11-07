using System;
namespace MicrosoftDS_A.InsertionSort
{
    public class InsertionSort
    {
        public InsertionSort()
        {

        }
        public static void Sort()
        {
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            Console.WriteLine("Array before sort: 7,8,4,6,2,1");

            int newValue;

            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                int j = i;

                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];

                    j--;
                }

                arr[j] = newValue;
            }

            Console.Write("Array after sort: ");
            foreach (int val in arr)
            {
                Console.Write(val + ",");
            }
            Console.WriteLine();
        }
    }
}
