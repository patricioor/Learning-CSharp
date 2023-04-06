namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos () {
            System.Console.WriteLine("FilhoReconhecido");

            System.Console.WriteLine(InfoPublica);
            System.Console.WriteLine(CorDoOlho);
            System.Console.WriteLine(NumeroCelular);
            System.Console.WriteLine(JeitoDeFalar);
            System.Console.WriteLine(SegredoFamilia);
            //System.Console.WriteLine(UsaMuitoPhotoshop); Não tem acesso
        }
    }
}