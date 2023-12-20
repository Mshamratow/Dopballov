using System;

class Program
{
    static string Diamond(int n)
    {

        if (n <= 0 || n % 2 == 0)
        {
            Console.WriteLine("Необходимо ввести положительное нечётное число!");
            return null;
        }

        string diam = "";
        for (int i = 1; i <= n; i += 2)
        {
            diam += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
        }

        for (int i = n - 2; i >= 1; i -= 2)
        {
            diam += new string(' ', (n - i) / 2) + new string('*', i) + "\n";
        }

        return "\n" + diam;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string inputString = Console.ReadLine();
        if (int.TryParse(inputString, out int n))
        {
            string result = Diamond(n);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
        Console.ReadKey();
    }
}