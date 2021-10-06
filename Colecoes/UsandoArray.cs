using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; // É uma estrutura estática, é uma estrutura homogênea 
            alunos[0] = "Cassia";
            alunos[1] = "Bia";
            alunos[2] = "Albert";
            alunos[3] = "Ana";
            alunos[4] = "Adenilson";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = {9, 8, 5, 6, 9};

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);



            char[] letras = { 'A', 'r', 't', 'y', 'o' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }


    }
}
