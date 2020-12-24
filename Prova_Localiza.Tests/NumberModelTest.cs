using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova_Localiza.Models;

namespace Prova_Localiza.Tests
{
    [TestClass]
    public class NumberModelTest
    {

        /// <summary>
        /// Testa se o metodo consegue identificar os numeros primos
        /// </summary>
        [TestMethod]
        public void IsPrimeNumberTest()
        {
            NumberModel number = new NumberModel(7);
            Assert.IsTrue(number.PrimeNumber);

            number = new NumberModel(5);
            Assert.IsTrue(number.PrimeNumber);

            number = new NumberModel(13);
            Assert.IsTrue(number.PrimeNumber);

            number = new NumberModel(17);
            Assert.IsTrue(number.PrimeNumber);
        }

        /// <summary>
        /// Testa se o metodo consegue identificar que os numeros não são primos
        /// </summary>
        [TestMethod]
        public void NotPrimeNumberTest()
        {
            NumberModel number = new NumberModel(6);
            Assert.IsFalse(number.PrimeNumber);

            number = new NumberModel(9);
            Assert.IsFalse(number.PrimeNumber);

            number = new NumberModel(10);
            Assert.IsFalse(number.PrimeNumber);

            number = new NumberModel(10);
            Assert.IsFalse(number.PrimeNumber);
        }
    }
}
