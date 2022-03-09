using System;

namespace Questão07
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Funcionario salarioPessoa1 = new Funcionario();

            salarioPessoa1.nome = "Tales";
            salarioPessoa1.SalarioBase = 2500;
            salarioPessoa1.TotalVendas = 10000;
            salarioPessoa1.PorcentagemComissão = 1;

            Console.WriteLine("O salário final do funcionário "+salarioPessoa1.nome+" é de "+salarioPessoa1.CalcularSalarioFinal()+"R$.");

        }
    }
}
