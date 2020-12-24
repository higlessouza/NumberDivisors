using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova_Localiza.Models;
using Prova_Localiza.Services;

namespace Prova_Localiza.Tests
{
    [TestClass]
    public class NumberDecompositionServiceTest
    {
        /// <summary>
        /// Teste para buscar divisores do numero 1
        /// </summary>
        [TestMethod]
        public void GetNumberDivisorsTest()
        {
            List<NumberModel> Divisors  = NumberDecompositionService.GetNumberDivisors(1);
            Assert.AreEqual(1, Divisors[0].Number);
            Assert.IsTrue(Divisors[0].PrimeNumber);
            Assert.AreEqual(1, Divisors.Count);
        }

        /// <summary>
        /// Teste para buscar divisores do numero 90
        /// </summary>
        [TestMethod]
        public void GetNumberDivisors2Test()
        {
            List<NumberModel> Divisors = NumberDecompositionService.GetNumberDivisors(90);

            Assert.AreEqual(2, Divisors[1].Number);
            Assert.IsTrue(Divisors[1].PrimeNumber);

            Assert.AreEqual(3, Divisors[2].Number);
            Assert.IsTrue(Divisors[2].PrimeNumber);

            Assert.AreEqual(5, Divisors[3].Number);
            Assert.IsTrue(Divisors[3].PrimeNumber);

            Assert.AreEqual(6, Divisors[4].Number);
            Assert.IsFalse(Divisors[4].PrimeNumber);

            Assert.AreEqual(9, Divisors[5].Number);
            Assert.IsFalse(Divisors[5].PrimeNumber);

            Assert.AreEqual(10, Divisors[6].Number);
            Assert.IsFalse(Divisors[6].PrimeNumber);

            Assert.AreEqual(15, Divisors[7].Number);
            Assert.IsFalse(Divisors[7].PrimeNumber);

            Assert.AreEqual(18, Divisors[8].Number);
            Assert.IsFalse(Divisors[8].PrimeNumber);

            Assert.AreEqual(30, Divisors[9].Number);
            Assert.IsFalse(Divisors[9].PrimeNumber);

            Assert.AreEqual(45, Divisors[10].Number);
            Assert.IsFalse(Divisors[10].PrimeNumber);

            Assert.AreEqual(90, Divisors[11].Number);
            Assert.IsFalse(Divisors[11].PrimeNumber);

            Assert.AreEqual(12, Divisors.Count);
        }

        /// <summary>
        /// Teste para buscar divisores do numero 1345
        /// </summary>
        [TestMethod]
        public void GetNumberDivisors3Test()
        {
            List<NumberModel> Divisors = NumberDecompositionService.GetNumberDivisors(1345);

            Assert.AreEqual(5, Divisors[1].Number);
            Assert.IsTrue(Divisors[1].PrimeNumber);

            Assert.AreEqual(269, Divisors[2].Number);
            Assert.IsTrue(Divisors[2].PrimeNumber);

            Assert.AreEqual(1345, Divisors[3].Number);
            Assert.IsFalse(Divisors[3].PrimeNumber);

            Assert.AreEqual(4, Divisors.Count);
        }

        /// <summary>
        /// Teste para buscar divisores de um numero negativo
        /// Deve retornar uma lista vazia
        /// </summary>
        [TestMethod]
        public void GetNumberNegativeDivisorsTest()
        {
            List<NumberModel> Divisors = NumberDecompositionService.GetNumberDivisors(-90);
            Assert.AreEqual(0, Divisors.Count);
        }
    }
}
