using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                textBox1.Enabled = false;
            }
            else if (e.KeyCode == Keys.Insert)
            {
                textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Presionaste enter, sus datos se guardaron: " + textBox1.Text);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Presionaste esc, saldras de la ventana");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
