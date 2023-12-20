using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину массива: ");
        string inputString = Console.ReadLine();
        if (int.TryParse(inputString, out int length))
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-10, 11);
            }

            Console.WriteLine("Сгенерированный массив:");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            int? result = FindClosestToZero(array);

            Console.WriteLine($"\nБлижайшее к 0 значение: {result}");
        }
        else
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
        Console.ReadKey();
    }


    static int? FindClosestToZero(int[] numbers)
    {
        int closest = int.MaxValue;

        foreach (int number in numbers)
        {
            if (Math.Abs(number) < Math.Abs(closest) || (number == 0 && closest != 0))
            {
                closest = number;
            }
            else if (Math.Abs(number) == Math.Abs(closest) && number != closest)
            {
                return null;
            }
        }

        return closest;
    }
}
