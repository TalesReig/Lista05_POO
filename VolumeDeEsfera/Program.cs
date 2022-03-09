using System;

namespace VolumeDeEsfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera Bolinha = new Esfera();
            Bolinha.raio = 10;

            Console.WriteLine("A o volume é de: "+Bolinha.CalcularVolume());
        }
    }
}
