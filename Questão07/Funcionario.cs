namespace Questão07
{
    internal class Funcionario
    {
        public string nome;
        public double SalarioBase;
        public double TotalVendas;
        public double PorcentagemComissão;

        public double CalcularSalarioFinal()
        {
            double ComissãoCalculada = PorcentagemComissão/100;
            double resultado = SalarioBase + (TotalVendas * ComissãoCalculada);
            return resultado;
        }
    }
}