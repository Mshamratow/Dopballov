using System.Linq;
using System;

public static class ArrayExtensions
{
    public static int[] Square(this int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i] * array[i];
        }
        return result;
    }

    public static int[] Cube(this int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i] * array[i] * array[i];
        }
        return result;
    }

    public static double Average(this int[] array)
    {
        if (array.Length == 0)
            return double.NaN;

        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return (double)sum / array.Length;
    }

    public static int Sum(this int[] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return sum;
    }

    public static int[] Even(this int[] array)
    {
        int[] result = array.Where(x => x % 2 == 0).ToArray();
        return result;
    }

    public static int[] Odd(this int[] array)
    {
        int[] result = array.Where(x => x % 2 != 0).ToArray();
        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] originalArray = new int[10];
        Random random = new Random();
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.Next(1, 20);
        }

        int[] squaredArray = originalArray.Square();
        int[] cubedArray = originalArray.Cube();
        double averageValue = originalArray.Average();
        int sumValue = originalArray.Sum();
        int[] evenNumbers = originalArray.Even();
        int[] oddNumbers = originalArray.Odd();

        Console.WriteLine("\nМассив: " + string.Join(", ", originalArray));
        Console.WriteLine("\nКвадрат элементов массива: " + string.Join(", ", squaredArray));
        Console.WriteLine("\nКуб элементов массива: " + string.Join(", ", cubedArray));
        Console.WriteLine("\nСреднее значение: " + averageValue);
        Console.WriteLine("\nСумма элементов массива: " + sumValue);
        Console.WriteLine("\nЧётные элементы массива: " + string.Join(", ", evenNumbers));
        Console.WriteLine("\nНечётные элементы массива: " + string.Join(", ", oddNumbers));
        Console.ReadKey();
    }
   
}
