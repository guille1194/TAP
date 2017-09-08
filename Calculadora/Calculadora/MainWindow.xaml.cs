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

namespace Calculadora
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

        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }

        private void Resultado_click(object sender, RoutedEventArgs e)
        {
            try
            {
                resultado();
            }
            catch (Exception exc)
            {
                tb.Text = "Errror!";
            }
        }

        private void resultado()
        {
            String op;
            int eOp = 0;
            if (tb.Text.Contains("+"))
            {
                eOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                eOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                eOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                eOp = tb.Text.IndexOf("/");
            }
            else
            {
                //error
            }
            op = tb.Text.Substring(eOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, eOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(eOp + 1, tb.Text.Length - eOp - 1));

            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else
            {
                tb.Text += "=" + (op1 / op2);
            }
        }
    }
}
