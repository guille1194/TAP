using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10Hilos
{
    public class Program
    {
        public void calculaPares()
        {
            int cont = 0;
            for (int i = 1; i <= 800000; cont += (i % 2 == 0 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("pares {0}", cont);
        }

        public void calculaImpares()
        {
            int cont = 0;
            for (int i = 1; i <= 800000; cont += (i % 2 == 1 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("Impares {0}", cont);
        }

        public static void Main(string[] args)
        {
            Program obj1 = new Program();
            System.Console.WriteLine("pares hasta el 800,000");
            obj1.calculaPares();
            obj1.calculaImpares();
            Console.ReadKey();
        }
    }
}
