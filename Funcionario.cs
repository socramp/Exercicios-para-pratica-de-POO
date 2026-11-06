using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        public decimal Salario { get; private set; }

        public Funcionario()
        {
            Salario = 1500;
        }

        public void AumentarSalario(int porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100m));
            Console.WriteLine($"Seu novo salário é: {Salario:C}");
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Seu salário é: {Salario:C}");
        }
    }
}