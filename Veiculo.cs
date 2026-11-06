using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício
{
    public class Veiculo
    {
        public int velocidade { get; private set; }

        public void alterarVelocidade(int nVelocidade)
        {
            if(nVelocidade <= 0 || nVelocidade >= 200)
            {
                Console.WriteLine("Velocidade não permitida");
            }
            else
            {
                velocidade = nVelocidade;
            }
        }
    }
}