using System;

class Program
{
    // Funkcja sprawdzająca, czy liczba jest liczbą pierwszą
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    // Funkcja wypisująca n liczb pierwszych
    static void PrintPrimeNumbers(int n)
    {
        int count = 0;  // Licznik znalezionych liczb pierwszych
        int number = 2; // Aktualnie sprawdzana liczba

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

    static void Main()
    {
        Console.WriteLine("Program wyświetla liczby pierwsze.");
        Console.Write("Podaj liczbę liczb pierwszych do wyświetlenia: ");
        int n = int.Parse(Console.ReadLine());

        PrintPrimeNumbers(n);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
