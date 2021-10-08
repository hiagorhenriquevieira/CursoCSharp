using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var diretorioProjeto = @"~/PastaTestandoCursoCSharpDestino".ParseHome();

            var diretorioInfo = new DirectoryInfo(diretorioProjeto);

            if (!diretorioInfo.Exists)
            {
                diretorioInfo.Create();
            }

            Console.WriteLine("== Arquivos =========");
            var arquivos = diretorioInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n == Diretorios =========");
            var pastas = diretorioInfo.GetDirectories();
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(diretorioInfo.FullName);
            Console.WriteLine(diretorioInfo.Parent);
            Console.WriteLine(diretorioInfo.Root);
            Console.WriteLine(diretorioInfo.CreationTime);
        }
    }
}
