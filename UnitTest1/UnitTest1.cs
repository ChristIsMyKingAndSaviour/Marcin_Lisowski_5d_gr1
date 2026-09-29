using Xunit;

namespace TestowanieSortowania
{
    public class SortInsercyjnyTesty
    {
        private readonly SortInsercyjny _sort = new SortInsercyjny();

        [Fact]
        public void Sortuj_NieuporzadkowanaTablica_ZwracaPosortowana()
        {
           int[] dane = { 5, 2, 9, 1, 5, 6 };
           int[] oczekiwany = { 1, 2, 5, 5, 6, 9 };

           var wynik = _sort.Sortuj(dane);

           Assert.Equal(oczekiwany, wynik);
        }

        [Fact]
        public void Sortuj_PustaTablica_ZwracaPustaTablice()
        {
           int[] dane = { };

           var wynik = _sort.Sortuj(dane);

           Assert.Empty(wynik);
        }

        [Fact]
        public void Sortuj_JedenElement_ZwracaTeSamaTablice()
        {
           int[] dane = { 7 };

           var wynik = _sort.Sortuj(dane);

           Assert.Equal(new[] { 7 }, wynik);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 4, 4, 4 }, new[] { 4, 4, 4 })]
        public void Sortuj_RozneDane_ZwracaOczekiwanaTablice(
           int[] wejscie, int[] oczekiwany)
        {
           var wynik = _sort.Sortuj(wejscie);

           Assert.Equal(oczekiwany, wynik);
        }

        [Fact]
        public void Sortuj_TablicaWejsciowa_NieJestModyfikowana()
        {
            int[] dane = { 3, 1, 2 };

            _sort.Sortuj(dane);

            Assert.Equal(new[] { 3, 1, 2 }, dane);
        }
    }
}
