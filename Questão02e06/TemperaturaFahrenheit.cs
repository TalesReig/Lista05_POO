namespace Questão02e06
{
    internal class TemperaturaFahrenheit
    {
        public double TempFahrenheit;

        public double ConverteParaFahrenheit()
        {
            double resultado = (TempFahrenheit - 32) / 1.8;
            return resultado;
        }
    }
}