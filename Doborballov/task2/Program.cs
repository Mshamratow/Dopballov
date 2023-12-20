using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество слов: ");
        string inputString = Console.ReadLine();
        if (int.TryParse(inputString, out int length))
        {
            string[] words = new string[length];

            Console.WriteLine($"Введите {length} слов для их сортировки по возрастанию:");

            for (int i = 0; i < length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("\nИсходный массив:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            var sortedWords = words.OrderBy(word => word.Length).ToArray();


            Console.WriteLine("\nОтсортированный массив:");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
          Console.ReadKey();  
    }
}
