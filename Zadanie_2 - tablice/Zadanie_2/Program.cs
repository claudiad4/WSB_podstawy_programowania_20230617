using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int najmniejszy = tablica[0]; // Inicjalizacja najmniejszego elementu jako pierwszy element tablicy
        int największy = tablica[0]; // Inicjalizacja największego elementu jako pierwszy element tablicy

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i]; // Aktualizacja najmniejszego elementu, jeśli znaleziono mniejszy element
            }

            if (tablica[i] > największy)
            {
                największy = tablica[i]; // Aktualizacja największego elementu, jeśli znaleziono większy element
            }
        }

        Console.WriteLine("Najmniejszy element: " + najmniejszy); // Wyświetlenie najmniejszego elementu
        Console.WriteLine("Największy element: " + największy); // Wyświetlenie największego elementu
    }
}
