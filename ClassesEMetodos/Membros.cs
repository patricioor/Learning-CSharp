using System;

namespace Projeto_CSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Patricio";
            fulano.Idade = 21;
   
            var beltrano = new Pessoa();
            beltrano.Nome = "Zé";
            beltrano.Idade = 30;

            fulano.Zerar();

            if(fulano.Nome.Length == 0 || fulano.Idade == 0){
                System.Console.WriteLine("Nome, e/ou idade, não preenchido");
            } else {
            var apresentarBeltrano = beltrano.Apresentar();
            System.Console.WriteLine(apresentarBeltrano);
            beltrano.ApresentarNoConsole();
            }
            var apresentarFulano = fulano.Apresentar();
            System.Console.WriteLine(apresentarFulano);
            fulano.Zerar();
            fulano.ApresentarNoConsole();
        }
    }
}