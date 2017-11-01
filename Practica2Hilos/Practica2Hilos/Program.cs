using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica2Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(EscribeY);
            t.Start();
            while (true)
                Console.Write("x"); //Escribe x indefinidamente
        }
        static void EscribeY()
        {
            while (true)
                Console.Write("y"); //Escribe y indefinidamente
        }
    }
}
