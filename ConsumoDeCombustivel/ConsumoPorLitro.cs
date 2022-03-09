namespace ConsumoDeCombustivel
{
    internal class ConsumoPorLitro
    {
        public int KmInicial;
        public int KmFinal;
        public int LitrosDeGasolinaInicial;
        public int LitrosDeGasolinaFinal;
        double ResultadoDeKmPorLitro;
        double ResultadoDeAutonomia;
        public double KmPorLitro()
        {
            ResultadoDeKmPorLitro = (KmFInal - KmInicial) * (LitrosDeGasolinaInicial - LitrosDeGasolinaInicial);
            return ResultadoDeKmPorLitro;
        }

        public double Autonomia()
        {
            ResultadoDeAutonomia = (LitrosDeGasolinaFinal * ResultadoDeKmPorLitro);
            return ResultadoDeAutonomia;
        }
    }
}