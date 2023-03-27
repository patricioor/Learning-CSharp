using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    public class StructVsClass
    {
        public static void Executar() {
            var ponto1 = new SPonto {X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; // Struct = Atribuição por Valor!
            ponto1.X = 3;

            System.Console.WriteLine("Ponto 1 X: {0}", ponto1.X); // X = 3
            System.Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X); // X = 1

            CPonto ponto2 = new CPonto {X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2; // Class = Atribuição por Referência!
            ponto2.X = 4;

            System.Console.WriteLine("Ponto 2, X: {0}", ponto2.X); // X = 4
            System.Console.WriteLine("Copia Ponto 2, X : {0}", copiaPonto2.X); // X = 4

            }
    }
}