﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            /*DECLARAÇÃO DA VARIAVEL
            *A CONDIÇÃO QUE VAI DETERMINAR SE É VERDADEIRA
            *INCREMENTO QUE VAI UTILIZAR
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"O valor de i é {i}.");
            }
            */


            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0} ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma {0}", media);
        }
    }
}