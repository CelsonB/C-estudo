using System;
using System.Collections.Generic;

using Portifolio.Fundamentos;
using Portifolio.MetodosEFuncoes;
using Portifolio.OrientadoAObjetos;
using Portifolio.MetodosEFuncoes;
using Portifolio.Excecoes;
using Portifolio.Api;
using Portifolio.TopicosAvancados;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Segundo Programa - Notação ponto", NotacaoPonto.Executar},
                {"Terceiro Programa - Ler console", LendoDados.Executar},
                {"Quarto programa  - Herança", Heranca.Executar},
                {"Quinto programa  - Cosntrutor This", ConstrutorThis.Executar},
                {"Sexto Programa - Encapsulamento", Portifolio.OrientadoAObjetos.Encapsulamento.Executar},
                {"Setimo Programa - Exemplo Lambda", ExemploLambda.Executar},
                {"Oitavo Programa - Lambda delegate", LambdaDelegate.Executar},
                {"Nono Programa - Usando delegate", UsandoDelegate.Executar},
                {"Decimo Programa - Delegate função anonima", DelegateFuncAnonima.Executar},
                {"Decimo Primeiro Programa - Delegate com parametros", DelegateComParametros.Executar},
                {"Decimo Segundo Programa - Metodos de extensão", MetodosDeExtensao.Executar},
                {"Decimo Terceiro Programa - Exceções", PrimeiraExcecao.Executar},
                {"Decimo Quarto Programa - Exceções personalizadas", ExcecoesPersonalizada.Executar},

                //api
                 {"Decimo Quinto Programa - Usando API", PrimeiroArquivo.Executar},
                 {"Decimo Sexto programa - Lendo arquivos", LendoArquivos.Executar},
                 {"Decimo Setimo programa - Exemplo FileInfo()", ExemploFileInfo.Executar},
                 {"Decimo Oitavo programa - Diretorios", Diretorios.Executar},
                 {"Decimo Oitavo programa - Exemplo directoryInfo", ExemploDirectoryInfo.Executar},
                {"Decimo Oitavo programa - Exemplo Path", ExemploPath.Executar},

                ///LINQ
                ///
                {"Decimo Nono programa - Exemplo LINQ1", LINQ1.Executar },
                  {"Programa de numero vinte - Exemplo LINQ2", LINQ2.Executar }




            }); ;

            central.SelecionarEExecutar();
        }
    }
}