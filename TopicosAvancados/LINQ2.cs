using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    { 
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 20, Nota = 8.0},
                new Aluno() {Nome = "Ana", Idade = 19, Nota = 7.2},
                new Aluno() {Nome = "Eduardo", Idade = 21, Nota = 8.5},
                new Aluno() {Nome = "Paulo", Idade = 22, Nota = 6.4},
                new Aluno() {Nome = "Ana", Idade = 20, Nota = 4.1},
                new Aluno() {Nome = "Jorge", Idade = 18, Nota = 7.8},
                new Aluno() {Nome = "Julia", Idade = 20, Nota = 7.9}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente.");
            }



            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            if (outraAna == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);


            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);


            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
