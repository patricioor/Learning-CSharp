using System;
using System.Collections.Generic;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Pessoa {
        public int Id  {get; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}  
        public new List<Livro> LivrosEmprestados;

        public Pessoa (int idPessoa, string nome, string cpf, string telefone) {
            Id = idPessoa;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            LivrosEmprestados = new List<Livro>();
        }
    
        public void AdicionarLivroLista(Livro livro){
            LivrosEmprestados.Add(livro);
        }
    }   
}