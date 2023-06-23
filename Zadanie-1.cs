using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }
            number++;
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
