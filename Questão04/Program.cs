using System;

namespace Questão04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            carro1.KmInicial = 100000;
            carro1.KmFinal = 100100;
            carro1.LitrosDeGasolinaInicial = 100;
            carro1.LitrosDeGasolinaFinal = 90;

            Console.WriteLine("O Consumo deste caro por litro é de : "+carro1.KmPorLitro()+"Km/l.");
        }

    }
}
