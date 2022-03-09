namespace Questão10
{
    internal class MediaPonderada
    {
        public int PesoNota1;
        public int PesoNota2;
        public double Nota1;
        public double Nota2;

        public double CalcularMedia()
        {
            double resultado = ((Nota1 * PesoNota1) + (Nota2 * PesoNota2)) / (PesoNota1 + PesoNota2);
            return resultado;
        }
    }
}