using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 6000.00;

            Console.WriteLine("O " + nome + " da marca "
                + marca + " custa " + preco +"R$.");
            Console.WriteLine("O {0} da marca {1} custa {2}R$.", nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1} !");
        }
    }
}
