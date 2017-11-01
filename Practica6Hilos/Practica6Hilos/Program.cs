using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica6Hilos
{
    class Program
    {
        static bool hecho;
        static object bloqueador = new object();
        static void Main(string[] args)
        {
            new Thread(VamosAlla).Start();
            VamosAlla();
        }
        static void VamosAlla()
        {
            lock (bloqueador)
            {
                if (!hecho)
                {
                    Console.WriteLine("Hecho");
                    hecho = true;
                    Console.ReadKey();
                }
            }
        }
    }
}
