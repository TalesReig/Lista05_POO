﻿using System;

namespace CaluladoraDeVolumeDeCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro lataDeOleo = new Cilindro();

            lataDeOleo.altura = 10;
            lataDeOleo.raio = 1;

            Console.WriteLine("O volume desté cilindro é de:" + lataDeOleo.CalculaVolume());
        }
    }   
}
