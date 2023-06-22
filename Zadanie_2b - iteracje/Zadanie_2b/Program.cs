using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wersja 2: Losowanie liczby parzystej od razu");
        Console.Write("Podaj liczbę liczb parzystych do wyświetlenia: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int count = 0;    // Licznik wylosowanych liczb parzystych
        int number;

        Console.Write("Wylosowane liczby parzyste: ");

        while (count < n)
        {
            number = random.Next(-4, 5) * 2;  // Losowanie liczby parzystej od razu

            Console.Write(number);

            count++;

            if (count < n)
            {
                Console.Write(", ");  // Dodanie przecinka i spacji poza ostatnią liczbą
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba rzeczywistych losowań: " + count);

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
