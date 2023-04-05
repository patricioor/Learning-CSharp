﻿using System;
using System.Collections.Generic;

using CSharp.Fundamentos;
using CSharp.EstruturasDeControle;
using Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca;
using Projeto_CSharp.ClassesEMetodos;
using Projeto_CSharp.ProjetoBanco;
using Projeto_CSharp.Colecoes;

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

                //Estruturas de Controle
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do-While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break; - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue; - Estruturas de Controle", UsandoContinue.Executar },

                // Classes & Métodos
                {"Membros: Atributos e Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"ExemploEnum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Class vs Struct - Classes e Métodos", StructVsClass.Executar},
                {"Valor vs Referência- Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência- Classes e Métodos", ParametrosPorReferencia.Executar},

                
                //Coleções
                {"Array - Coleções", Projeto_CSharp.Colecoes.Array.Executar},
                {"List - Coleções", Projeto_CSharp.Colecoes.List.Executar},
                {"ArrayList - Coleções", Projeto_CSharp.Colecoes.ArrayList.Executar},
                {"Set - Coleções", Projeto_CSharp.Colecoes.Set.Executar},
                {"Queue - Coleções", Projeto_CSharp.Colecoes.Queue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Projeto_CSharp.Colecoes.Stack.Executar},
                {"Dicionário - Coleções", Projeto_CSharp.Colecoes.Dictionary.Executar},

                //Exercícios
                {"Exercício: Múltiplos de 2,3,4 e 5", Multiplos2345.Executar },
                {"Exercício: Número primo", NumeroPrimo.Executar },
                {"Exercício: Menor Diferença - Estruturas de Controle", ExercicioMenorDiferenca.Executar },
                {"Projeto: Biblioteca", ExecutarBiblioteca.Executar },
                {"Projeto: Banco Simples", TerminalBanco.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
