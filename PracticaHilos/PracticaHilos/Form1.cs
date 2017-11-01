using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PracticaHilos
{
    public partial class Form1 : Form
    {
        int Posicion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posicion = Posicion + 30;
            CrearProgressBars(23, Posicion, 23, 200);
            
        }
        private void CrearProgressBars(int sX, int sY, int sAltura, int sAncho)
        {
            ProgressBar pb = new ProgressBar();
            int ContarHasta = new Random().Next(100000, 5000000);
            pb.SetBounds(sX, sY, sAncho, sAltura);
            pb.Parent = this;
            pb.CreateControl();
            for (int contador = 1; contador <= 100; contador++)
            {
                pb.Value = contador;
                for (int CuentaNumeros = 0; CuentaNumeros <= ContarHasta; CuentaNumeros++);
            }
        }
    }
}
