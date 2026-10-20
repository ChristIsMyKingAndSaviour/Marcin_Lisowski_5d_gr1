using System;
using System.Collections.Generic;
using System.Text;

namespace TestowanieSortowania
{
    public class SortBabelkowy
    {
        public int[] Sortuj(int[] tablica)
        {
            int[] wynik = (int[])tablica.Clone();
            int n = wynik.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (wynik[j] > wynik[j + 1])
                    {
                        int temp = wynik[j];
                        wynik[j] = wynik[j + 1];
                        wynik[j + 1] = temp;
                    }
                }
            }
            return wynik;
        }
    }

    
}
