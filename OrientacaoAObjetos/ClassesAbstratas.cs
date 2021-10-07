using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    public abstract class Celular //Ela pode ter todos metodos abstratos ou todos não abstratos.
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "trim trim trim...";
        }
    }
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Bixby";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Jaax";
        }
    }

    class ClassesAbstratas
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
