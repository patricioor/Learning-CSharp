namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo Projeto (Assembly)
        internal ulong NumeroCelular = 5585999999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            System.Console.WriteLine("SubCelebridade");

            System.Console.WriteLine(InfoPublica);
            System.Console.WriteLine(CorDoOlho);
            System.Console.WriteLine(NumeroCelular);
            System.Console.WriteLine(JeitoDeFalar);
            System.Console.WriteLine(SegredoFamilia);
            System.Console.WriteLine(UsaMuitoPhotoshop);

        }
    }
}