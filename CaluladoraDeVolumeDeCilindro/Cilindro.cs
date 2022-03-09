namespace CaluladoraDeVolumeDeCilindro
{
    internal class Cilindro
    {
        public double altura;
        public double raio;

        public double CalculaVolume()
        {
            double resultado = ((3.14 * System.Math.Pow(raio, 2)) * altura);
            return resultado;
        }
    }
}