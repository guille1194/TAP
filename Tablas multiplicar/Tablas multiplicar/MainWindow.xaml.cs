using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tablas_multiplicar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(textBox1.Text);
            int resultado;

            for (int i = 1; i < 11; i++)
            {
                resultado = tabla * i;
                listBox1.Items.Add(tabla + "x" + i + "=" + resultado);
            }
        }
    }
}
