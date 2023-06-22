using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 78, 15, 21, 98, 100, 215, 416, 49, 62 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWybieranie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i; // Przechowuje indeks najmniejszego elementu w nieposortowanej części tablicy

            // Znajdowanie indeksu najmniejszego elementu w nieposortowanej części tablicy
            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            // Zamiana miejscami najmniejszego elementu z pierwszym elementem nieposortowanej części
            if (indeksMinimum != i)
            {
                ZamienElementy(tablica, i, indeksMinimum);
            }
        }
    }

    static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
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
