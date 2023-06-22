using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 14, 69, 74, 18, 41, 258, 781, 5, 3 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i]; // Zapisanie wartości bieżącego elementu jako klucz
            int j = i - 1;

            // Przesuwanie większych elementów w prawo, aby zrobić miejsce dla klucza
            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz; // Wstawienie klucza na właściwą pozycję
        }
    }

    static void WypiszTablice(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i]);

            if (i < tablica.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
