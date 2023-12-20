using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] smileyArray = { ":)", ":D", ";-D", ":~)", ";(", ":>", ":}]" };

        Console.WriteLine($"Общее количество улыбающихся лиц: {CountSmileys(smileyArray)}");
        Console.ReadKey();
    }

    static int CountSmileys(string[] arr)
    {
        int count = 0;
        foreach (string smiley in arr)
        {
            if (IsValidSmiley(smiley))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsValidSmiley(string smiley)
    {
        char[] validEyes = { ':', ';' };
        char[] validNoses = { '-', '~' };
        char[] validMouths = { ')', 'D' };

        if (!validEyes.Contains(smiley[0]))
        {
            return false;
        }

        if (smiley.Length > 1 && validNoses.Contains(smiley[1]))
        {
            if (smiley.Length > 2 && !validMouths.Contains(smiley[2]))
            {
                return false;
            }
        }
        else
        {
            if (smiley.Length > 1 && !validMouths.Contains(smiley[1]))
            {
                return false;
            }
        }

        return true;
    }
}

