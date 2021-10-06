using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //raio da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 4.3;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos
            bool estaChovendo = false;
            Console.WriteLine("Não está chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Maior salario" + salario);

            int menorValorInt = int.MinValue;  //Mais usado dos inteiros!
            Console.WriteLine("Menor valor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("O preço do computador é " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000;
            Console.WriteLine("Valor de mercado da Apple" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);


        }
    }
}

