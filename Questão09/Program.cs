using System;

namespace Questão09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MediaArmonica M1 = new MediaArmonica();

            M1.NumeroDeTermos = 4;
            M1.Valores[1] = 1;
            M1.Valores[2] = 2;
            M1.Valores[3] = 3;
            M1.Valores[4] = 4;

            Console.WriteLine("A média armonica dos " +M1.NumeroDeTermos+ " é :" +M1.CalcularMediaArmonica());
        }
    }
}
