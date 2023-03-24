using System;

namespace Projeto_CSharp.ClassesEMetodos {
    public class Biblioteca {
        public new List<Pessoa> Pessoas { get; set;}
        public new List<Livro> Livros {get; set;}

        public Biblioteca () {
            Pessoas = new List<Pessoa>();
            Livros = new List<Livro>();
        }

        public void CadastrarPessoa(Pessoa pessoa) {
            Pessoas.Add(pessoa);
        }

        public void CadastrarLivro(Livro livro) {
            Livros.Add(livro);
        }

        public bool verificarIdPessoa (int idPessoa) {
            if(Pessoas.Exists(p => p.Id == idPessoa)){
                return true;
            } 
            else {
                return false;
            }
        }

        public bool verificarIdLivro (int idLivro) {
            if(Livros.Exists(l => l.Id == idLivro)) {
                return true;
            } 
            else{
                return false;
            }
        }

        public string pegarTituloLivroPeloId(int idLivro){
            return Livros.Find(l => l.Id == idLivro).Titulo;
        }


        public string pegarNomePessoaPeloId(int idPessoa) {
            return Pessoas.Find(p => p.Id == idPessoa).Nome;
        }

        public int pegarQtdExemplaresPeloIdLivro(int idLivro) {
            return Livros.Find(l => l.Id == idLivro).QuantidadeExemplares;
        }

        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa) {
            Livro livro = Livros.Find(i => i.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro != null && pessoa != null) {
                Console.Write("Insira a quantidade de livros que serão emprestados: ");
                int.TryParse(Console.ReadLine(),out int qnt);
                livro.EmprestarLivro(qnt);
                livro.QntLivrosEmprestados = qnt;
                
                Console.WriteLine("Foi efetuado o empréstimo de {0} exemplares", qnt);
                pessoa.AdicionarLivroLista(livro);
                pessoa.QntLivrosEmprestadosUsuario = qnt;
                livro.QntLivrosEmprestados = pessoa.QntLivrosEmprestadosUsuario;
                Console.WriteLine($"Ainda há '{livro.SaldoExemplares}' exemplares disponíveis para empréstimo");

            }
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa) {
            Livro livro = Livros.Find(i=> i.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if(livro != null && pessoa != null) {
                Console.Write ("Insira a quantidade de livros que serão devolvidos:");
                int.TryParse(Console.ReadLine(),out int qntDevolvida);
                if(qntDevolvida == livro.QntLivrosEmprestados) pessoa.RemoverLivroLista(idPessoa);
                if(qntDevolvida > livro.QntLivrosEmprestados) {
                    Console.WriteLine("Você não possui essa quantidade de exemplares. Possui {0} exemplares", livro.QntLivrosEmprestados);
                } else {
                    livro.QntLivrosEmprestados -= qntDevolvida;
                    if(livro.SaldoExemplares != livro.QuantidadeExemplares) livro.SaldoExemplares += qntDevolvida;
                }
            }
        }

    }
}