using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10; // liczba parzystych liczb do wylosowania
        int counter = 0; // licznik losowań

        Console.WriteLine("Wersja 2: Losowanie liczby parzystej od razu");

        for (int i = 0; i < n;)
        {
            int randomNumber = random.Next(-4, 5) * 2;

            Console.Write(randomNumber);

            i++;

            if (i < n)
            {
                Console.Write(", ");
            }

            counter++;
        }

        Console.WriteLine();
        Console.WriteLine("Liczba wykonanych losowań: " + counter);
    }
}

