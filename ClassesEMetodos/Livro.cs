using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Livro
    {
        public int Id {get; set;}
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string Editora {get; set;}
        public int QuantidadeExemplares {get; set;}
        public int SaldoExemplares {get; set;}
        public int QntLivroEmprestados {get; set;}
        public int qntDevolvida{get; set;}

        public Livro(int idLivro, string titulo, string autor,string editora,int qtdExemplares) {
            Id = idLivro;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = qtdExemplares;

        }

        public void EmprestarLivro(int quantidadeEmprestada) {
            if(QuantidadeExemplares<= quantidadeEmprestada){
                System.Console.WriteLine("Não há exemplares o suficiente para emprestar");
                return;
            } else {
                SaldoExemplares = -(quantidadeEmprestada - QuantidadeExemplares);
                QntLivroEmprestados = quantidadeEmprestada;
                Console.WriteLine($"Ainda há '{SaldoExemplares}' exemplares disponíveis para empréstimo");
            }
        }

        public void DevolverLivro(int quantidadeDevolvida, int SaldoExemplares) {
            System.Console.WriteLine("Foram devolvidos '{0}' exemplares.", quantidadeDevolvida);
            QuantidadeExemplares = SaldoExemplares + quantidadeDevolvida;
        }
    }
}