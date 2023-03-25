using System;
using System.Collections.Generic;

using CSharp.Fundamentos;
using CSharp.EstruturasDeControle;
using Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca;
using Projeto_CSharp.ClassesEMetodos;

namespace CSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"Variáveis e Constantes - Fundamentos", VariáveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                {"Exercício: Múltiplos de 2,3,4 e 5", Multiplos2345.Executar },
                {"Exercício: Número primo", NumeroPrimo.Executar },

                //Estruturas de Controle
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do-While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break; - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue; - Estruturas de Controle", UsandoContinue.Executar },
                {"Exercício: Menor Diferença - Estruturas de Controle", ExercicioMenorDiferenca.Executar },

                // Classes & Métodos
                {"Membros: Atributos e Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Projeto: Biblioteca", ExecutarBiblioteca.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
