namespace Questão04
{
    internal class Carro
    {
        public int KmInicial;
        public int KmFinal;
        public int LitrosDeGasolinaInicial;
        public int LitrosDeGasolinaFinal;
        double ResultadoDeKmPorLitro;
        double ResultadoDeAutonomia;
        public double KmPorLitro()
        {
            ResultadoDeKmPorLitro = (KmFinal - KmInicial) / (LitrosDeGasolinaInicial - LitrosDeGasolinaFinal);
            return ResultadoDeKmPorLitro;
        }

        public double Autonomia()
        {
            ResultadoDeAutonomia = (LitrosDeGasolinaFinal * ResultadoDeKmPorLitro);
            return ResultadoDeAutonomia;
        }
    }
}