using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string NomeDaPessoa;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {NomeDaPessoa} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar()
        {
            NomeDaPessoa = "";
            Idade = 0;
        }
    }
}
