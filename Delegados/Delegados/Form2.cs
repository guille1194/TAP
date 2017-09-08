using System;
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
    public partial class Form2 : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasado(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
