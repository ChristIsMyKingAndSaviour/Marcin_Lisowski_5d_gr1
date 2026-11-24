using System;
using System.Collections.Generic;
using System.Text;

using System;
using Xunit;

namespace TestowanieSortowania
{
    public class AkceptacyjneTesty
    {
        private readonly SortPozycyjne _sorter = new SortPozycyjne();

        [Fact]
        public void Akceptacyjny_ZestawLiczbWielocyfrowych_UzytkownikOtrzymujePoprawnaKolejnosc()
        {
         
            int[] daneUzytkownika = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int[] oczekiwanyWynik = { 2, 24, 45, 66, 75, 90, 170, 802 };

          
            int[] wynik = _sorter.Sortuj(daneUzytkownika);

            
            Assert.Equal(oczekiwanyWynik, wynik);
        }

        [Fact]
        public void Akceptacyjny_TablicaZPowtorzeniamiIZerami_PoprawniePorzadkujeDane()
        {
       
            int[] daneUzytkownika = { 0, 50, 10, 50, 0, 5 };
            int[] oczekiwanyWynik = { 0, 0, 5, 10, 50, 50 };

          
            int[] wynik = _sorter.Sortuj(daneUzytkownika);

          
            Assert.Equal(oczekiwanyWynik, wynik);
        }

        [Fact]
        public void Akceptacyjny_PojedynczyElement_ZwracaTenSamElement()
        {
           
            int[] daneUzytkownika = { 91 };
            int[] oczekiwanyWynik = { 99 };

           
            int[] wynik = _sorter.Sortuj(daneUzytkownika);

          
            Assert.Equal(oczekiwanyWynik, wynik);
        }

        [Fact]
        public void Akceptacyjny_PustaTablica_ZwracaPustyWynikBezBledu()
        {
         
            int[] daneUzytkownika = Array.Empty<int>();

           
            int[] wynik = _sorter.Sortuj(daneUzytkownika);

           
            Assert.Empty(wynik);
        }
    }
}