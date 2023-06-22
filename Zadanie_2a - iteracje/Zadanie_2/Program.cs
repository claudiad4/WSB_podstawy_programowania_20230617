using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wersja 1: Sprawdzanie poprawności losowania po losowaniu");
        Console.Write("Podaj liczbę liczb parzystych do wyświetlenia: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int count = 0;    // Licznik wylosowanych liczb parzystych
        int number;

        Console.Write("Wylosowane liczby parzyste: ");

        while (count < n)
        {
            number = random.Next(-8, 9);  // Losowanie liczby z przedziału [-8, 8]

            if (number % 2 == 0)  // Sprawdzenie, czy liczba jest parzysta
            {
                Console.Write(number);

                count++;

                if (count < n)
                {
                    Console.Write(", ");  // Dodanie przecinka i spacji poza ostatnią liczbą
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba rzeczywistych losowań: " + count);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
