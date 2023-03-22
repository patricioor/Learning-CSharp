﻿using System;


namespace CSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ",i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma é: {0}", media);
        }
    }
}
