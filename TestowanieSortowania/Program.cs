using System;
using System.Linq;
using TestowanieSortowania;

public class Program
{
    public static void Main(string[] args)
    {
        // Jeśli testy systemowe uruchamiają Main bez argumentów lub z pustymi, zapobiegamy błędom
        if (args != null && args.Length > 0 && args[0] == "test")
        {
            return;
        }

        Console.WriteLine("=== SYSTEM SORTOWANIA DANYCH (SELECTION SORT) ===");
        Console.Write("Wprowadź liczby rozdzielone spacjami: ");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Błąd: Nie wprowadzono danych.");
            return;
        }

        try
        {
            int[] liczby = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            var sorter = new SortWybieranie();
            int[] wynik = sorter.Sortuj(liczby);

            Console.WriteLine("Posortowane liczby: " + string.Join(", ", wynik));
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Wprowadzono niepoprawne dane (wymagane liczby całkowite).");
        }
    }
}