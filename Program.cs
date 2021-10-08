using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaves e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando  Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição- Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Tenario - Fundamentos", OperadorTernario.Executar},
                
                //Estrutura de controle
                {"Estrutura do If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura do If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura do If/Else If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Contiunue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", AtributosEstaticos.Executar},
                {"Parametros Variáveis - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get and Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrão  - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", UsandoArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", UsandoArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionery - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objeto
                {"Herança - Orientação a Objeto", Heranca.Executar},
                {"Construtor This - Orientação a Objeto", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objeto", UsandoEncapsulamento.Executar},
                {"Polimorfismo Orientação a Objeto", UsandoPolimorfismo.Executar},
                {"Classes Abstratas - Orientação a Objeto", ClassesAbstratas.Executar},
                {"Interface - Orientação a Objeto", Interface.Executar},
                {"Sealed - Orientação a Objeto", ClassSealed.Executar},
                
                //Métodos e Funcões 
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Função Anonima Delegate - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegate Como Parametros - Métodos e Funções", DelegateComoParametros.Executar},
                {"Metodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                //Exceções 
                {"Tratamento de Erro - Exceções", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivo.Executar},
                {"Exemplo File Info - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"Exemplo Directory Info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                //Topicos Avançados
                {"LINQ #01  - Topicos Avançados", LINQ1.Executar},
                {"LINQ #02  - Topicos Avançados", LINQ2.Executar},
                {"Nullables   - Topicos Avançados", Nullables.Executar},
                {"Dynamics   - Topicos Avançados", Dynamics.Executar},
                {"Genericos  - Topicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}