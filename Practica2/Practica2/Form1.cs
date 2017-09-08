using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label2.Text = DateTime.Now.ToString("MMMM");
            label3.Text = DateTime.Now.ToString("dddd");
            label4.Text = DateTime.Now.ToString("yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
