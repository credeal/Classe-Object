using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj;//Retorna uma excessão caso não de para converter
            Cliente outroCliente = obj as Cliente; //Retorna null caso não de para converter

            if (outroCliente == null)
                return false;

            return Nome == outroCliente.Nome &&
                   CPF  == outroCliente.CPF  &&
                   Profissao == outroCliente.Profissao;

        }
    }
}
