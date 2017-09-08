using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = textBox1.Text;
            if (e.KeyChar == Convert.ToChar('S') || e.KeyChar == Convert.ToChar('s'))
            {
                i++;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter) && i == 1)
            {
                MessageBox.Show("Usted presiono " + textBox1.Text);
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter) && i > 1)
            {
                MessageBox.Show("Usted presiono S " + i + " veces");
            }

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
