using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova_Localiza.Models
{
    public class NumberModel
    {
        private int number;
        private bool primeNumber;

        public NumberModel(int value)
        {
            this.number = value;
            this.primeNumber = IsPrimeNumber(value);
        }

        public int Number { get => number; set => number = value; }
        public bool PrimeNumber { get => primeNumber; set => primeNumber = value; }

        /// <summary>
        /// Verifica se o numero é primo
        /// </summary>
        /// <param name="number"> Numero para ser verificado</param>
        /// <returns></returns>
        static bool IsPrimeNumber(int number)
        {
            int factor = number / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }
    }
}