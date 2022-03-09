namespace Questão09
{
    internal class MediaArmonica
    {
        public int NumeroDeTermos;
        public double[] Valores;
        public double SomaInverso;

        public double CalcularMediaArmonica()
        {
            SomaInverso = SomaDoInverso();
            double resultado = NumeroDeTermos / SomaInverso;
            return resultado;
        }

        public double SomaDoInverso()
        {
            SomaInverso = 0;
            for (int i = 0; i < NumeroDeTermos; i++)
            {
                SomaInverso = SomaInverso + (1 / Valores[i]);
            }
            return SomaInverso;
        }
    }
}