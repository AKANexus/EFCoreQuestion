using System;
using System.Collections.Generic;
using System.Text;

namespace AmbiStore.Shared.Extension
{
    public static class IntExtensions
    {
        /// <summary>
        /// Retorna verdadeiro se o número está entre os limites estabelecidos.
        /// </summary>
        /// <param name="value">Valor a ser comparado</param>
        /// <param name="lowerValue">Limite inferior</param>
        /// <param name="higherValue">Limite superior</param>
        /// <param name="inclusive">Permitir os limites inclusive</param>
        /// <returns></returns>
        public static bool IsBetween(this int value, int lowerValue, int higherValue, bool inclusive = true)
        {
            if (inclusive)
            {
                if (value <= higherValue && value >= lowerValue) return true;
                else return false;
            }
            else
            {
                if (value < higherValue && value > lowerValue) return true;
                else return false;
            }
        }
    }
}
