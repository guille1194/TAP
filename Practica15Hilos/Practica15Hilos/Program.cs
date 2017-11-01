using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica15Hilos
{
    public class mensaje
    {
        String msg_;

        public mensaje(String valor)
        {
            msg_ = valor;
        }

        public String msg
        {
            get { return msg_; }
            set { msg_ = value; }
        }
    }

    public class Program
    {
        public void calculaPares(object nombre)
        {
            int cont = 0;
            System.Console.WriteLine("iniciando {0}", ((mensaje)nombre).msg);
            for (int i = 1; i <= 800000; cont += (i % 2 == 0 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("pares {0}", cont);
        }

        private void calculaImpares(object nombre)
        {
            int cont = 0;
            System.Console.WriteLine("iniciando {0}", ((mensaje)nombre).msg);
            for (int i = 1; i <= 800000; cont += (i % 2 == 1 ? 1 : 0), i += 1) ;
            System.Console.WriteLine("Impares {0}", cont);
        }

        public static void Main(string[] args)
        {
            Program obj1 = new Program();
            mensaje objMsg1 = new mensaje("pares");
            mensaje objMsg2 = new mensaje("impares");
            Console.WriteLine("pares hasta el 800,000");
            Thread t1 = new Thread(obj1.calculaPares);
            Thread t2 = new Thread(obj1.calculaImpares);
            t1.Start(objMsg1);
            t2.Start(objMsg2);
            Console.ReadKey();
        }
    }
}