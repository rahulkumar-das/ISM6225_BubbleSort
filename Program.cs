using System;

public class Class1

{
    static void Main(string[] args)
    {
        int [] bubbleSort = { 5, 72, 3, 14, 7, 1 };
        Console.WriteLine("This is the original unsorted array:");

        Console.WriteLine(bubbleSort);
        for (int i = 0; i < bubbleSort.Length; i++)
        {
            Console.WriteLine(" " + bubbleSort[i]);
        }
        Console.WriteLine("Here is the sorted array: ");
        Bubble_Sort(bubbleSort);
        for (int i = 0; i < bubbleSort.Length; i++) {
            Console.WriteLine(" "+bubbleSort[i]);
                }

    }

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
