namespace ConversorDeTemperatura.ConsoleApp
{
    internal class TemperaturaFahrenheit
    {
        public double TempFahrenheit;

        public double ConverteParaCelcius()
        {
            double resultado = (TempFahrenheit - 32) / 1.8;
            return resultado;
        }
    }
}