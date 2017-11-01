using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica5Hilos
{
    class Program
    {
        static bool hecho;
        static void Main(string[] args)
        {
            new Thread(VamosAlla).Start();
            VamosAlla();
        }
        static void VamosAlla()
        {
            if(!hecho)
            {
                hecho = true;
                Console.WriteLine("Hecho");
                Console.ReadKey();
            }
        }
    }
}
