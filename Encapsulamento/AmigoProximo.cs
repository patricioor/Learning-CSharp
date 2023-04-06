namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        
        public void MeusAcessos() {
            System.Console.WriteLine("Amigo Próximo");

            System.Console.WriteLine(amiga.InfoPublica);
            //System.Console.WriteLine(amiga.CorDoOlho);
            System.Console.WriteLine(amiga.NumeroCelular);
            System.Console.WriteLine(amiga.JeitoDeFalar);
            //System.Console.WriteLine(amiga.SegredoDeFamilia);
            //System.Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }

    }
}
