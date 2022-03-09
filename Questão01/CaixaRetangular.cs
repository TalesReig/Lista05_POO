namespace Questão01
{
    internal class CaixaRetangular
    {
        public double comprimento;
        public double largura;
        public double altura;

        public double CalcularVolume()
        {
            double volume = comprimento * largura * altura;
            return volume;
        }
    }
}