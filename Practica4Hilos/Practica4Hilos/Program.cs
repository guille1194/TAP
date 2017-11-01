using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica4Hilos
{
    class PruebaHilos
    {
        bool hecho;
        static void Main(string[] args)
        {
            PruebaHilos ph = new PruebaHilos();
            new Thread(ph.VamosAlla).Start();
        }
        void VamosAlla()
        {
            if (!hecho)
            {
                hecho = true;
                Console.WriteLine("Hecho");
                Console.ReadKey();
            }
        }
    }
}
