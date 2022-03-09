using System;

namespace Questão05
{
    internal class Esfera
    {
        public double raio;

        public double CalcularVolume()
        {
            double resultado = (4 / 3) * (3.14 * Math.Pow(raio, 3));
            return resultado;
        }
    }
}