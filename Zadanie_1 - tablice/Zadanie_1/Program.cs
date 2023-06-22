using System;

class Program
{
    static void Main(string[] args)
    {
        int rozmiarTablicy = 10;
        int[] tablica = new int[rozmiarTablicy];
        Random rand = new Random();

        // Wypełnienie tablicy losowymi wartościami
        for (int i = 0; i < rozmiarTablicy; i++)
        {
            tablica[i] = rand.Next(1, 101);
        }

        // Wywołanie metody wypiszOdTylu
        wypiszOdTylu(tablica);
    }

    static void wypiszOdTylu(int[] tablica)
    {
        int indeks = tablica.Length - 1;
        while (indeks >= 0)
        {
            Console.WriteLine(tablica[indeks]);
            indeks = indeks - 1;
        }
    }
}

