using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        int size = 0;

        while (attempts < 3)
        {
            Console.Write("Podaj rozmiar rombu (liczba nieparzysta >= 3): ");
            if (int.TryParse(Console.ReadLine(), out size) && size >= 3 && size % 2 != 0)
            {
                DrawDiamond(size);
                break;
            }
            else
            {
                Console.WriteLine("Podałeś zły rozmiar");
                attempts++;
            }
        }

        if (attempts >= 3)
        {
            Console.WriteLine("Przekroczono limit prób. Koniec programu.");
        }
    }

    static void DrawDiamond(int size)
    {
        List<char> borderChars = new List<char> { '#', '@', '|', '*' };
        List<char> innerChars = new List<char> { '.', ':', '-', '+' };
        Random random = new Random();

        int spaces = size / 2;
        int chars = 1;

        for (int row = 0; row < size; row++)
        {
            for (int space = 0; space < spaces; space++)
            {
                Console.Write(" ");
            }

            for (int charCount = 0; charCount < chars; charCount++)
            {
                char character;
                if (row < size / 2)
                {
                    character = borderChars[random.Next(borderChars.Count)];
                }
                else
                {
                    character = innerChars[random.Next(innerChars.Count)];
                }

                Console.Write(character);
            }

            Console.WriteLine();

            if (row < size / 2)
            {
                spaces--;
                chars += 2;
            }
            else
            {
                spaces++;
                chars -= 2;
            }
        }
    }
}

