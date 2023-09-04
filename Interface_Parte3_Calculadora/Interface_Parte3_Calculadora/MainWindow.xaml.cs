using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

namespace Interface_Parte3_Calculadora
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
        string numero1 = "";
        string muestra;
        int operacion;
        double a, b, r;
        
      

        private void Button_Click_Punto(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + ".";
            txtmuestra.Text += muestra + ".";
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "0";
            txtmuestra.Text += muestra + "0";
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "1";
            txtmuestra.Text += muestra + "1";
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "2";
            txtmuestra.Text += muestra + "2";
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "3";
            txtmuestra.Text += muestra + "3";
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "4";
            txtmuestra.Text += muestra + "4";
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "5";
            txtmuestra.Text += muestra + "5";
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "6";
            txtmuestra.Text += muestra + "6";
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "7";
            txtmuestra.Text += muestra + "7";
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "8";
            txtmuestra.Text += muestra + "8";
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            numero1 = numero1 + "9";
            txtmuestra.Text += muestra + "9";
        }
        private void Button_Click_Porcentual(object sender, RoutedEventArgs e)
        {
            operacion = 1;
            numero1 += ",";
            txtmuestra.Text += muestra + "%";
        }
        private void Button_Click_Dividir(object sender, RoutedEventArgs e)
        {
            operacion = 2;
            numero1 += ",";
            txtmuestra.Text += muestra + "/";
        }
        private void Button_Click_Multiplicar(object sender, RoutedEventArgs e)
        {
            operacion = 3;
            numero1 += ",";
            txtmuestra.Text += muestra + "x";
        }
        private void Button_Click_Restar(object sender, RoutedEventArgs e)
        {
            operacion = 4;
            numero1 += ",";
            txtmuestra.Text += muestra + "-";
        }
        private void Button_Click_Sumar(object sender, RoutedEventArgs e)
        {
            operacion = 5;
            numero1 += ",";
            txtmuestra.Text += muestra + "+";
        }
        private void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            numero1 = "";
            txtmuestra.Text = "";
            a = 0;
            b = 0;
            r = 0;

        }

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            try
            {   string del = numero1.Remove(numero1.Length - 1, 1);
                numero1 = del;
                string del2 = txtmuestra.Text.Remove(txtmuestra.Text.Length - 1, 1);
                txtmuestra.Text = del2;
            }catch(Exception) { MessageBox.Show("no hay nada que borrar"); }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string[] a2 = numero1.Split(',');
                Console.WriteLine(a2[0].ToString() + " , " + a2[1].ToString());
                string b2 = a2[0].Replace('.', ',');
                string b3 = a2[1].Replace('.', ',');


                a = double.Parse(b2);
                b = double.Parse(b3);
                Console.WriteLine(a + " , " + b);


                switch (operacion)
                {
                    case 1:
                        r = (a / 100) * b;
                        break;
                    case 2:
                        try { r = a / b; }
                        catch { MessageBox.Show("no se puede dividir por cero"); }
                        break;
                    case 3:
                        r = a * b;
                        break;
                    case 4:
                        r = a - b;
                        break;
                    case 5:
                        r = a + b;
                        break;
                }
                Console.WriteLine(r);
            
                txtResultado.Text = r.ToString();
            }
            catch { MessageBox.Show("introduce algo"); }
            
            
            

        }

        
    }
}
