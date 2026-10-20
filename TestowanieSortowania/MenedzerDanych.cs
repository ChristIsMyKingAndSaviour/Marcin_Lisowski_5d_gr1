using System;
using System.Collections.Generic;
using System.Text;

namespace TestowanieSortowania
{
    public class MenedzerDanych
    {
        private readonly SortBabelkowy _sorter;

        public MenedzerDanych()
        {
            _sorter = new SortBabelkowy();
        }

        public int[] PrzetworzIZwroc(int[] nieposortowaneDane)
        {
            if (nieposortowaneDane == null || nieposortowaneDane.Length == 0)
            {
                return new int[0];
            }

            
            return _sorter.Sortuj(nieposortowaneDane);
        }
    }
}
