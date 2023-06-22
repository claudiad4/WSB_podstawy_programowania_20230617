using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta, którego chcesz zbudować: ");
        int height = int.Parse(Console.ReadLine());

        int maxWidth = height * 2 - 1; // Maksymalna szerokość trójkąta

        for (int row = 1; row <= height; row++)
        {
            int numPlus = row * 2 - 1; // Liczba znaków '+' w danym wierszu
            int numSpaces = (maxWidth - numPlus) / 2; // Liczba spacji przed znakami '+'

            // Wypisanie spacji
            for (int i = 0; i < numSpaces; i++)
            {
                Console.Write(" ");
            }

            // Wypisanie znaków '+'
            for (int i = 0; i < numPlus; i++)
            {
                Console.Write("+");
            }

            Console.WriteLine(); // Przejście do nowego wiersza
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
