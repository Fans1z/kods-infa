using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = GenerateRandomArray(20);
        int[] array2 = GenerateRandomArray(20);

        Array.Sort(array1);
        Array.Sort(array2);

        Console.WriteLine("Массив 1:");
        PrintArray(array1);

        Console.WriteLine("\nМассив 2:");
        PrintArray(array2);

        Console.WriteLine("\nОбщие элементы в обоих массивах:");
        FindCommonElements(array1, array2);
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(0, 101);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void FindCommonElements(int[] array1, int[] array2)
    {
        var commonElements = new System.Collections.Generic.HashSet<int>();

        foreach (int num in array1)
        {
            if (BinarySearch(array2, num) && !commonElements.Contains(num))
            {
                commonElements.Add(num);
                Console.Write(num + " ");
            }
        }

        if (commonElements.Count == 0)
        {
            Console.WriteLine("Общих элементов нет.");
        }
    }

    static bool BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return true;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}
