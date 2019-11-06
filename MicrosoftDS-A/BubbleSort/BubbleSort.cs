using System;
namespace MicrosoftDS_A.BubbleSort
{
    public class BubbleSort
    {
        static BubbleSort()
        {
            // Pseudocode for Bubble Sort
            // bubbleSort(nums : list of numbers)
            // n = length of nums
            // loop
            //      swapped = false
            //      for i = 1 to n - 1
            //      if nums[i-1] > nums[i] then
            //          swap(nums[i-1] and nums[i])
            //          swapped = true
            // end if statement
            // end for statement
            // runs until swapped is false or end of list
            // end of bubbleSort

            //Console.WriteLine("Please enter a list of numbers that is not sorted: ");

            int[] nums = { 5, 10, 3, 2, 4 };

            Console.WriteLine($"Before {nums}" );
        }
    }
}
