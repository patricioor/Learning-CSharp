using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Cliente{
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(1996,03,20);
        }

        public string GetDataDeNascimento () {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,Nascimento.Month, Nascimento.Year);
        }
    }
    public class Readonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(year: 1992, month: 8, day: 18));

            System.Console.WriteLine(novoCliente.Nome);
            System.Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}