using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova_Localiza.Services;

namespace Prova_Localiza.Tests
{
    [TestClass]
    public class NumberDecompositionServiceTest
    {
        [TestMethod]
        public void GetNumberDivisorsTest()
        {
            NumberDecompositionService.GetNumberDivisors(90);
        }
    }
}
