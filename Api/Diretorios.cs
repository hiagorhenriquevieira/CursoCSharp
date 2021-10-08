using System;
using System.IO;


namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDiretorio = @"~/pastaTestandoCursoCSharp".ParseHome();
            var novoDiretorioDestino = @"~/PastaTestandoCursoCSharpDestino".ParseHome();
            var diretorioProjeto = @"~/source/repos/GitRepositories/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDiretorio))
            {
                Directory.Delete(novoDiretorio, true);
            }
            if (Directory.Exists(novoDiretorioDestino))
            {
                Directory.Delete(novoDiretorioDestino, true);
            }

            Directory.CreateDirectory(novoDiretorio);
            Console.WriteLine(Directory.GetCreationTime(novoDiretorio));

            Console.WriteLine("==== Pastas ===========");
            var pastas = Directory.GetDirectories(diretorioProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n == Arquivos ===========");
            var arquivos = Directory.GetFiles(diretorioProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n == Raiz =======");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDiretorio));



            Directory.Move(novoDiretorio, novoDiretorioDestino);
        }
    }
}
