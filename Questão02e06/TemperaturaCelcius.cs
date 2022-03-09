namespace Questão02e06
{
    internal class TemperaturaCelcius
    {
        public double TempCelcius;

        public double ConverteParaFahrenheit()
        {
            double resultado = (TempCelcius * 1.8) + 32;
            return resultado;
        }
    }
}