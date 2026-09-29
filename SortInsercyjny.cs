namespace TestowanieSortowania
{
    public class SortInsercyjny
    {
        public int[] Sortuj(int[] tablica)
        {
            if (tablica == null) return null;

            int[] wynik = (int[])tablica.Clone();

            for (int i = 1; i < wynik.Length; i++)
            {
                int klucz = wynik[i];
                int j = i - 1;

                while (j >= 0 && wynik[j] > klucz)
                {
                    wynik[j + 1] = wynik[j];
                    j--;
                }

                wynik[j + 1] = klucz;
            }

            return wynik;
        }
    }
}