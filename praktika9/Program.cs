using System;

class Program
{
    static void Main()
    {
        const int arraySize = 30;
        const int minValue = -30;
        const int maxValue = 100;
        int[] array = new int[arraySize];
        Random random = new Random();

        // Filling an array with random numbers in details [-30, 100]
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        // Finding the indices of the minimum and maximum elements
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex]) minIndex = i;
            if (array[i] > array[maxIndex]) maxIndex = i;
        }

        // Outputting the array before replacement
        Console.WriteLine("Array before replacement:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        // Exchange values ​​of minimum and maximum elements
        int temp = array[minIndex];
        array[minIndex] = array[maxIndex];
        array[maxIndex] = temp;

        // Array output after replacement
        Console.WriteLine("Array after replacing minimum and maximum elements:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
