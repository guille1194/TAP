using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica12Hilos
{
    public class Program
    {
        public void calculaPares()
        {
            int cont = 0;
            for (int i = 1; i <= 900000; cont += (i % 2 == 0 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("pares {0}", cont);
        }

        public void calculaImpares()
        {
            int cont = 0;
            for (int i = 1; i <= 900000; cont += (i % 2 == 1 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("Impares {0}", cont);
        }

        public static void Main(string[] args)
        {
            Program obj1 = new Program();
            Console.WriteLine("pares hasta el 900,000");
            Thread t1 = new Thread(obj1.calculaPares);
            Thread t2 = new Thread(obj1.calculaImpares);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
