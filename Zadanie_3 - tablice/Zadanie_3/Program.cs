using System;

class Program
{
    static void Main(string[] args)
    {
        int[] tablica = { 8, 15, 6, 12, 36, 64, 152, 19, 9 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana = true;

        while (zamiana)
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    ZamienElementy(tablica, i, i + 1);
                    zamiana = true; // Jeśli nastąpiła zamiana, to oznaczamy, że tablica jest jeszcze nieposortowana
                }
            }

            n--; // Zmniejszamy rozmiar tablicy, ponieważ największy element "wypływa" na koniec po każdej iteracji
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
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
