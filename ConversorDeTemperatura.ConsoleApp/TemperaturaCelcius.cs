namespace ConversorDeTemperatura.ConsoleApp
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