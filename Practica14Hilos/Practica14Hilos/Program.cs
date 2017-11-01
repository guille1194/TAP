using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica14Hilos
{
    class Program
    {
        private void calculaPares(object nombre)
        {
            int cont = 0;
            System.Console.WriteLine("iniciando {0}", nombre);
            for (int i = 1; i <= 800000; cont += (i % 2 == 0 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("pares {0}", cont);
        }

        private void calculaImpares(object nombre)
        {
            int cont = 0;
            System.Console.WriteLine("iniciando {0}", nombre);
            for (int i = 1; i <= 800000; cont += (i % 2 == 1 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("Impares {0}", cont);
        }

        public static void Main(string[] args)
        {
            Program obj1 = new Program();
            Console.WriteLine("pares hasta el 800,000");
            Thread t1 = new Thread(obj1.calculaPares);
            Thread t2 = new Thread(obj1.calculaImpares);
            t1.Start("pares");
            t2.Start("impares");
            Console.ReadKey();
        }
    }
}
