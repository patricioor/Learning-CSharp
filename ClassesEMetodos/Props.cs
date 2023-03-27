using System;


namespace Projeto_CSharp.ClassesEMetodos
{   
    class CarroOpcional {
        double desconto = 0.1; // default: private
        string nome;
        public string Nome { get{ return "Opcional: " + nome;}  set{ nome = value;}}
        // Propriedade autoimplementada
        public double Preco {get; set;}

        public double PrecoComDesconto {get => Preco - (desconto * Preco);}
        public double PrecoComDesconto2 { get { return Preco - (desconto * Preco);}}

        public CarroOpcional() {}

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }

    public class Props
    {
        public static void Executar(){
            var op1 = new CarroOpcional("Ar Condicionado", 3499.99);

            System.Console.WriteLine(op1.PrecoComDesconto);
            System.Console.WriteLine(op1.PrecoComDesconto2);

            // op1.PrecoComDesconto = 3000; -> Erro: somente leitura.

            var op2 = new CarroOpcional();

            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.99;

            System.Console.WriteLine(op1.Nome);
            System.Console.WriteLine(op1.Preco);

            System.Console.WriteLine(op2.Nome);
            System.Console.WriteLine(op2.Preco);
            System.Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}