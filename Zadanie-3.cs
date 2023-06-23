using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int height = int.Parse(Console.ReadLine());

        if (height <= 0)
        {
            Console.WriteLine("Błąd ERROR wysokość musi być >0");
            return;
        }

        int width = 2 * height - 1;
        for (int row = 1; row <= height; row++)
        {
            int numPluses = 2 * row - 1;
            int numSpaces = width - numPluses;

            string rowContent = new string(' ', numSpaces / 2) + new string('+', numPluses) + new string(' ', numSpaces / 2);
            Console.WriteLine(rowContent);
        }
    }
}

