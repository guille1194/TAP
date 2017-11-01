using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica8Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(WriteAzul);
            Thread t2 = new Thread(WriteRojo);
            t1.Start();
            t2.Start();
            for(int i=0; i<100; i++)
            {
                Console.Write("Cony");
            }
            Console.ReadKey();

        }

        static void WriteAzul()
        {
            for (int i=0; i<100; i++)
            {
                Console.WriteLine("Azul");
            }
        }
        static void WriteRojo()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Rojo");
            }
            Console.ReadKey();
        }
    }
}
