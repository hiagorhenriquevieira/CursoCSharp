using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar ()
        {
            /* Cenario TV 50 && ( and )
             * Verdadeiro && Verdadeiro = Verdadeiro
             * Verdadeiro && Falso = Falso
             * Falso && Verdadeiro = Falso
             * Falso && Falso = Falso
             * 
             * Cenario Sorvete || ( or )
             * Verdadeiro || Verdadeiro = Verdadeiro
             * Verdadeiro || Falso = Verdadeiro
             * Falso || Verdadeiro = Verdadeiro
             * Falso || Falso = Falso
             *
             * Cenario TV 32 ^ (xor)
             * Verdadeiro ^ Verdadeiro = Falso
             * Verdadeiro ^ Falso = Verdadeiro
             * Falso ^ Verdadeiro = Verdadeiro
             * Falso ^ Falso = Falso
             */

            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou a TV32? {0}", comprouTv32);
            
            /* Utilização de ! é a negação de algo, ou seja... 
             * Verdadeiro se torna Falso 
             * e Falso se torna Verdadeiro;
             */

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}
