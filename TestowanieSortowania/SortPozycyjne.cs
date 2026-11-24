using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace TestowanieSortowania
{
    public class SortPozycyjne
    {
        public int[] Sortuj(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                return new int[0];
            }

            int[] wynik = (int[])tablica.Clone();
            int max = PobierzMaksimum(wynik);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                SortujPoCyfrze(wynik, exp);
            }

            return wynik;
        }

        private int PobierzMaksimum(int[] tablica)
        {
            int max = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
            }
            return max;
        }

        private void SortujPoCyfrze(int[] tablica, int exp)
        {
            int n = tablica.Length;
            int[] wyjscie = new int[n];
            int[] licznik = new int[10];

            for (int i = 0; i < n; i++)
            {
                int cyfra = (tablica[i] / exp) % 10;
                licznik[cyfra]++;
            }

            for (int i = 1; i < 10; i++)
            {
                licznik[i] += licznik[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int cyfra = (tablica[i] / exp) % 10;
                wyjscie[licznik[cyfra] - 1] = tablica[i];
                licznik[cyfra]--;
            }

            for (int i = 0; i < n; i++)
            {
                tablica[i] = wyjscie[i];
            }
        }
    }
}
