using System;

namespace Questão10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media1 = new MediaPonderada();

            media1.Nota1 = 8;
            media1.Nota2 = 9;
            media1.PesoNota1 = 3;
            media1.PesoNota2 = 2;

            Console.WriteLine("A média armonica desses valores é de : "+media1.CalcularMedia());
        }
    }
}
