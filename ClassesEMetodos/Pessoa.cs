using System;
using System.Collections.Generic;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Pessoa {
        public int Id  {get; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;} 
        public int QntLivrosEmprestadosUsuario { get; set;}
        public List<Livro> LivrosEmprestados;

        public Pessoa (int idPessoa, string nome, string cpf, string telefone, int qntLivrosEmprestadosUsuario) {
            Id = idPessoa;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            QntLivrosEmprestadosUsuario = qntLivrosEmprestadosUsuario;
            LivrosEmprestados = new List<Livro>();
        }
    
        public void AdicionarLivroLista(Livro livro){
            LivrosEmprestados.Add(livro);
        }

        public void RemoverLivroLista(int idPessoa) {
            LivrosEmprestados.RemoveAll(i => i.Id == idPessoa);
        }
    }   
}