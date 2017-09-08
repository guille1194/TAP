using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            progressBar1.Style = ProgressBarStyle.Continuous;
            if (Convert.ToInt32(progressBar1.Value) == 100)
            {
                timer1.Stop();
                timer1.Enabled = false;
                Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
