using System;

namespace Questão04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoPorLitro carro1 = new ConsumoPorLitro();

            carro1.KmInicial = 100000;
            carro1.KmFinal = 100100;
            carro1.LitrosDeGasolinaInicial = 100;
            carro1.LitrosDeGasolinaFinal = 90;
        }

    }
}
