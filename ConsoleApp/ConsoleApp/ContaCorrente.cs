using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ContaCorrente
    {
        public int Agencia { get; private set; }
        public int Numero { get; private set; }

        public ContaCorrente(int p_agencia, int p_numero)
        {
            Agencia = p_agencia;
            Numero = p_numero;
        }

        public override string ToString()
        {
            return $"Numero: {Numero} - Agência: {Agencia}";
        }
    }
}
