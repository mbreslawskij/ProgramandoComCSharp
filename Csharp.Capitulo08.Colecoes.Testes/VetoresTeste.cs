using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Csharp.Capitulo08.Colecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];
            inteiros[0] = 14;
            inteiros[1] = -8;
            //inteiros[5] = 0;

            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };

            foreach(var @decimal in decimais)
            {
               Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanhoo do vetor {nameof(decimais)} é: {decimais.Length}");

        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };

            Array.Resize(ref decimais, 5);

            decimais[4] = 2.3m;
        }
        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.4m, 7m, 3.2m, -1.4m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -1.4m);
        }
        public decimal Media(decimal x, decimal y)
        {
            x = 14.3m;
            y = 23.4m;
            decimal soma = x + y;

            decimal total = soma / 2;

            return total;
        }

        private decimal Media(decimal[] decimais);
    }
}
