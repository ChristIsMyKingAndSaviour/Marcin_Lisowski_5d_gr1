using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TestowanieSortowania
{
    public class SortWybieranie
    {
        [Fact]
        public void Systemowy_PoprawneDane_WyświetlaPosortowanąTablicę()
        {
            // Arrange
            var input = "64 25 12 22 11";
            var expectedOutput = "Posortowane liczby: 11, 12, 22, 25, 64";

            using (var sw = new StringWriter())
            using (var sr = new StringReader(input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                // Act
                Program.Main(new string[0]);

                // Assert
                var result = sw.ToString();
                Assert.Contains(expectedOutput, result);
            }
        }

        [Fact]
        public void Systemowy_PusteDane_WyświetlaKomunikatOBłędzie()
        {
            // Arrange
            var input = "";
            var expectedOutput = "Błąd: Nie wprowadzono danych.";

            using (var sw = new StringWriter())
            using (var sr = new StringReader(input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                // Act
                Program.Main(new string[0]);

                // Assert
                var result = sw.ToString();
                Assert.Contains(expectedOutput, result);
            }
        }

        [Fact]
        public void Systemowy_NiepoprawneDane_WyświetlaKomunikatOBłędzieFormatowania()
        {
            // Arrange
            var input = "10 abc 30";
            var expectedOutput = "Błąd: Wprowadzono niepoprawne dane";

            using (var sw = new StringWriter())
            using (var sr = new StringReader(input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                // Act
                Program.Main(new string[0]);

                // Assert
                var result = sw.ToString();
                Assert.Contains(expectedOutput, result);
            }
        }

        [Fact]
        public void Systemowy_JedenElement()
        {
            // Arrange
            var input = "7";
            var expectedOutput = "Posortowane liczby: 7";

            using (var sw = new StringWriter())
            using (var sr = new StringReader(input))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                // Act
                Program.Main(new string[0]);

                // Assert
                var result = sw.ToString();
                Assert.Contains(expectedOutput, result);
            }
        }
    }
}