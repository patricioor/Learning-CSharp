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
        public int QntLivrosEmprestados {get; set;}
        public int QntDevolvida{get; set;}

        public Livro(int idLivro, string titulo, string autor,string editora,int qtdExemplares, int saldoExplrs, int qntLivrosEmprestados, int qntDevolvida) {
            Id = idLivro;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = qtdExemplares;
            SaldoExemplares = saldoExplrs;
            QntLivrosEmprestados = qntLivrosEmprestados;
            QntDevolvida = qntDevolvida;

        }

        public void EmprestarLivro(int qntLivrosEmprestados) {
            if(QuantidadeExemplares < qntLivrosEmprestados && SaldoExemplares < qntLivrosEmprestados ){
                System.Console.WriteLine("Não há exemplares o suficiente para emprestar");
                return;
            } else {
                if( SaldoExemplares == 0) {
                    System.Console.WriteLine("if true {0}", SaldoExemplares);
                    SaldoExemplares = -(qntLivrosEmprestados - QuantidadeExemplares);
                    System.Console.WriteLine("if true {0} pos code", SaldoExemplares);
                } else {
                    SaldoExemplares -= qntLivrosEmprestados;
                    System.Console.WriteLine("if false {0}", SaldoExemplares);
                }
            }
        }

        public void DevolverLivro(int quantidadeDevolvida, int SaldoExemplares) {
            System.Console.WriteLine("Foram devolvidos '{0}' exemplares.", quantidadeDevolvida);
            QuantidadeExemplares = SaldoExemplares + quantidadeDevolvida;
        }
    }
}