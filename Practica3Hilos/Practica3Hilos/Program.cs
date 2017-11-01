using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica3Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(VamosAlla).Start();
            VamosAlla();
        }
        static void VamosAlla()
        {
            for (int ciclos = 0; ciclos < 5; ciclos++)
                Console.Write("?");
                Console.ReadKey();
        }
    }
}
