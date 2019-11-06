using System;
using MicrosoftDS_A.BubbleSort;

namespace MicrosoftDS_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ExponentCalculator();
            //CalculateCylinderVolume();
            //BubbleSort();
            BubbleSort.BubbleSort.Sort();

        }
        // Write an Algorithm, Pseudocode, and Code for calculating volume of a cyclinder.

        // Algorithm: V=pir^2h To find the volume we need to multiply the constant pi by the radius raised to the second power and the height of the cyclinder.
        // We will set a variables for pi, the result of the radius raised to the second power and height. We will then find the volume by multiplying all three varibles
        //  together.

        // Pseudocode:
        // SET pi = 3.14
        // SET radius = provided number * provided number
        // SET height = provided height
        // SET volume = pi * radius * height
        // OUTPUT volume

        // Code as described.
        static void CalculateCylinderVolume()
        {
            Console.WriteLine("Please give me a radius length: ");
            string userRadiusInput = Console.ReadLine();
            int radius = Convert.ToInt32(userRadiusInput);

            Console.WriteLine("Please enter a height: ");
            string userHeightInput = Console.ReadLine();
            int height = Convert.ToInt32(userHeightInput);

            double pi = 3.14;
            int radiusSquared = radius * radius;

            double cyclinderVolume = pi * radiusSquared * height;

            Console.WriteLine($"The volume of your cyclinder is {cyclinderVolume}");
        }
        static void ExponentCalculator()
        {
            // Allows user input of a base number
            Console.WriteLine("Please enter a base number: ");
            string numberBase = Console.ReadLine();
            int baseNumber = Convert.ToInt32(numberBase);
            Console.WriteLine($"Your base number is {baseNumber}");

            // Allows user input of an exponent to raise the base number to
            Console.WriteLine("Please enter an exponent: ");
            string exponentUser = Console.ReadLine();
            int usersExponent = Convert.ToInt32(exponentUser);
            Console.WriteLine($"Your exponent will be {usersExponent}");

            // Logic to raise the base number to the given power
            int result = baseNumber;
            int exponentToRaise = usersExponent - 1;

            while (exponentToRaise > 0)
            {
                result = result * baseNumber;
                exponentToRaise--;
            }

            Console.WriteLine($"Your result is {result}");
        }

        //static void BubbleSort()
        //{
        //    int[] nums = { 5, 10, 3, 2, 4 };

        //    Console.WriteLine("Before: 5, 10, 3, 2, 4");

        //    bool swapped;
        //    do
        //    {
        //        swapped = false;
        //        for (int i = 0; i < nums.Length - 1; i++)
        //        {
        //            if (nums[i] > nums[i + 1])
        //            {
        //                int temp = nums[i + 1];
        //                nums[i + 1] = nums[i];
        //                nums[i] = temp;
        //                swapped = true;
        //            }
        //        }
        //    } while (swapped == true);

        //    Console.Write("After: ");
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        Console.Write("{0}, ", nums[i]);
        //    }
        //    Console.ReadLine();
        //}

    }

}
