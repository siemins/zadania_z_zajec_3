using System;

class Program
{
    static void Main()
    {
        // Pobierz wartość x
        int x = GetPositiveInteger("Podaj liczbę naturalną x: ");

        // Pobierz wartość n
        int n = GetNonNegativeInteger("Podaj potęgę całkowitą nieujemną n: ");

        // Oblicz potęgę
        int result = CalculatePower(x, n);

        // Wyświetl wynik
        Console.WriteLine($"Wynik otrzymany napisanym algorytmem: {result}");

        // Porównaj z wynikiem funkcji bibliotecznej
        int libraryResult = (int)Math.Pow(x, n);
        Console.WriteLine($"Wynik biblioteczny: {libraryResult}");

        // Sprawdź zgodność wyników
        string message = result == libraryResult ? "Wyniki są zgodne." : "Wyniki są różne.";
        Console.WriteLine(message);
    }

    static int GetPositiveInteger(string prompt)
    {
        int value;
        bool isValid;
        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value) && value > 0;
            if (!isValid)
            {
                Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę naturalną.");
            }
        } while (!isValid);
        return value;
    }

    static int GetNonNegativeInteger(string prompt)
    {
        int value;
        bool isValid;
        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value) && value >= 0;
            if (!isValid)
            {
                Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą nieujemną.");
            }
        } while (!isValid);
        return value;
    }

    static int CalculatePower(int x, int n)
    {
        int result = x;
        for (int i = 1; i < n; i++)
        {
            int temp = 0;
            for (int j = 0; j < result; j++)
            {
                temp += x;
            }
            result = temp;
        }
        return result;
    }
}

