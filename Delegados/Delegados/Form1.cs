﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.pasado += new Form2.pasar(ejecutar); //se suscribe un evento
            form2.ShowDialog();
        }
        public void ejecutar (string dato)
        {
            label1.Text = dato;
        }
    }
}
