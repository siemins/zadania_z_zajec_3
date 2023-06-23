using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10; // liczba parzystych liczb do wylosowania
        int counter = 0; // licznik losowań

        Console.WriteLine("Wersja 1: Sprawdzanie poprawności losowania");

        for (int i = 0; i < n;)
        {
            int randomNumber = random.Next(-8, 9);

            if (randomNumber % 2 == 0)
            {
                Console.Write(randomNumber);

                i++;

                if (i < n)
                {
                    Console.Write(", ");
                }
            }

            counter++;
        }

        Console.WriteLine();
        Console.WriteLine("Liczba wykonanych losowań: " + counter);
    }
}

