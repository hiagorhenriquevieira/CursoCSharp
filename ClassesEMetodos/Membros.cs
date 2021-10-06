using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar ()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.NomeDaPessoa = "Renato";
            sicrano.Idade = 21;

            Console.WriteLine($"{sicrano.NomeDaPessoa} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.NomeDaPessoa = "Beto";
            fulano.Idade = 19;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
