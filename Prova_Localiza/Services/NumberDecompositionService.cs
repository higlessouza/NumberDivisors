using Prova_Localiza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Localiza.Services
{
    public static class NumberDecompositionService
    {
        static public List<NumberModel> GetNumberDivisors(int number)
        {
            List<NumberModel> divisors = new List<NumberModel>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    divisors.Add(new NumberModel(i));
            }
            return divisors;
        }
    }
}