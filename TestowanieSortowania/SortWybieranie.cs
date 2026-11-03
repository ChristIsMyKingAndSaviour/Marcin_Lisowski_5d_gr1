using System;
using System.Collections.Generic;
using System.Text;

namespace TestowanieSortowania
{
    public class SortWybieranie
    {
        public int[] Sortuj(int[] tablica)
        {
            if (tablica == null) return new int[0];

            int[] wynik = (int[])tablica.Clone();
            int n = wynik.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (wynik[j] < wynik[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = wynik[i];
                    wynik[i] = wynik[minIndex];
                    wynik[minIndex] = temp;
                }
            }

            return wynik;
        }
    }
}
