using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício
{
    public class Pessoas
    {
        public string? Nome { get; set; }
        
        public int Idade { get; set; }

        public string? Cidade { get; set; } 

        public void Apresentar()
        {
            Console.WriteLine($"Seu nome é {Nome}, você tem {Idade} anos e é de {Cidade}");
        }
    } 
}