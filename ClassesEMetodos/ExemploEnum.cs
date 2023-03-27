using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos{

    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    public class ExemploEnum
    {
        public static void Executar() {
            int id = (int) Genero.Animacao;
            System.Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Nemo";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;

            System.Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo,filmeParaFamilia.GeneroDoFilme);
        }
    }
}