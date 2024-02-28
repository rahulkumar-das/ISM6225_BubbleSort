
/*
Author: Rahulkumar Das
Date: 02/28/2024
Comments: This C# Console Application code demonstrates the
   Selection Sort and Bubble Sort Algorithms. No input
   is required for the script. It will execute without 
   input against two pre-populated arrays. 
*/

using System;

public class Class1

{
    static void Main(string[] args)
    {
        int [] bubbleSort = { 5, 72, 3, 14, 7, 1 };
        Console.WriteLine("This is the original unsorted array:");

        Console.WriteLine(bubbleSort);
        
        // Traversing through unsorted array
        for (int i = 0; i < bubbleSort.Length; i++)
        {
            Console.WriteLine(" " + bubbleSort[i]);
        }

        Console.WriteLine("Here is the sorted array: ");

        // calling Bubble_Sort function and passing the unsorted array
        Bubble_Sort(bubbleSort);

        // Printing the sorted array
        for (int i = 0; i < bubbleSort.Length; i++) {
            Console.WriteLine(" "+bubbleSort[i]);
                }

    }

    // Declaring Bubble_Sort method
    static void Bubble_Sort(int[] bs_arr)
    {
        for (int i = 0; i < bs_arr.Length - 1; i++)
        {
            for (int x = 0; x < bs_arr.Length - i - 1; x++)
            {
                if (bs_arr[x] > bs_arr[x + 1])
                {
                    int temp = bs_arr[x];
                    bs_arr[x] = bs_arr[x + 1];
                    bs_arr[x + 1] = temp;
                }
            }
        }
    }
}
