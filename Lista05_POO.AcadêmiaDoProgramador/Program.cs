using System;

namespace Lista05_POO.AcadêmiaDoProgramador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa1 = new CaixaRetangular();

            // comprimento, largura, altura.
            caixa1.comprimento = 10;
            caixa1.largura = 10;
            caixa1.altura = 10;

            Console.WriteLine("O volume da caixa é" + caixa1.CalcularVolume());
        }
    }
}
