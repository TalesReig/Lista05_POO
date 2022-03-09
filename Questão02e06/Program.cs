using System;

namespace Questão02e06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaCelcius t1 = new TemperaturaCelcius();

            t1.TempCelcius = 10;

            Console.WriteLine("Essa temp em graus Fahrenheit é de:" + t1.ConverteParaFahrenheit());

            TemperaturaFahrenheit t2 = new TemperaturaFahrenheit();

            t2.TempFahrenheit = 50;

            Console.WriteLine("Essa temp em graus Fahrenheit é de:" + t1.ConverteParaFahrenheit());
        }
    }
}
