using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente(123,123456);

            Cliente carlos = new Cliente();
            carlos.Nome = "Carlos";
            carlos.CPF = "123.123.123.123";
            carlos.Profissao = "Programador";

            Cliente carlos2 = new Cliente();
            carlos2.Nome = "Carlos";
            carlos2.CPF = "123.123.123.123";
            carlos2.Profissao = "Programador";

            Console.Write("Comparando por refênciar de mémoria: ");
            Console.WriteLine(carlos == carlos2 ? "Sim" : "Não");
            Console.Write("Comparando com equals: ");
            Console.WriteLine(carlos.Equals(carlos2) ? "Sim" : "Não");

            Console.WriteLine(c1);
        }
    }
}
