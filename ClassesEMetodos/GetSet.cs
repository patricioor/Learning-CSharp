using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Moto {
        private string Marca {get; set;}

        private string Modelo { get; set;}
        private uint Cilindrada {get; set;}

        public Moto (string marca, string modelo, uint cilindrada) {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {}

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo (string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada () {
            return Cilindrada;
        }

        public void SetCilindrada (uint cilindrada) {
            Cilindrada = cilindrada;
        }
    }
    public class GetSet
    {
        public static void Executar() {
            System.Console.WriteLine("Digite, em sequência, a marca, modelo e as cilindradas");
            var marca = Console.ReadLine(); 
            var modelo = Console.ReadLine(); 
            uint.TryParse(Console.ReadLine(), out uint cilindrada);

            var moto1 = new Moto(marca, modelo, cilindrada);
            System.Console.WriteLine("Marcar: {0}, Modelo: {1}, Cilindrada: {2}", moto1.GetMarca(), moto1.GetModelo(), moto1.GetCilindrada());
        }
    }
}