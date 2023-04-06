using Encapsulamento;

namespace Projeto_CSharp.OO
{
    public class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade {
            public new void MeusAcessos() {
                System.Console.WriteLine("Filho não reconhecido");

                System.Console.WriteLine(InfoPublica);
                System.Console.WriteLine(CorDoOlho);
                System.Console.WriteLine(NumeroCelular);
                System.Console.WriteLine(JeitoDeFalar);
                System.Console.WriteLine(SegredoFamilia);
                //System.Console.WriteLine(UsaMuitoPhotoshop);
            }
        }
        public class AmigoDistante {
            SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos() {
                System.Console.WriteLine("Público Comum");

                System.Console.WriteLine(amiga.InfoPublica);
                //System.Console.WriteLine(amiga.CorDoOlho);
                System.Console.WriteLine(amiga.NumeroCelular);
                System.Console.WriteLine(amiga.JeitoDeFalar);
                //System.Console.WriteLine(amiga.SegredoFamilia);
                //System.Console.WriteLine(amiga.UsaMuitoPhotoshop);
            
            }
        }
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            System.Console.WriteLine("");
            new AmigoProximo().MeusAcessos();
            System.Console.WriteLine("");
            new FilhoNaoReconhecido().MeusAcessos();
            System.Console.WriteLine("");
            new AmigoDistante().MeusAcessos();
        }
    }
}