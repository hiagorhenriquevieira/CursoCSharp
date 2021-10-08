﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            //Cuidado na utilização do Dynamic porque ele pode causar erro após a execução se não prestar atenção
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 9.8;
            aluno.idade = 23;

            Console.WriteLine($"{aluno.nome} {aluno.idade} {aluno.nota} ");
        }
    }
}
