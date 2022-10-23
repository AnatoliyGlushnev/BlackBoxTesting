using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace BlackBox1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Anwers_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, x1, x2, d, x;
            a = Convert.ToInt32(Achislo.Text);
            try
            {
                b = Convert.ToInt32(Bchislo.Text);
                c = Convert.ToInt32(Cchislo.Text);

                d = Math.Pow(b, 2) - (4 * a * c);

                if (d > 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Anwers1.Content += "\nx1=" + x1 + "\nx2=" + x2;
                }
                else if (d == 0)
                {
                    x = (-b + Math.Sqrt(d)) / (2 * a);
                    Anwers1.Content += "\nx" + x;
                }
                else
                    Anwers1.Content += "Нет действительный корней";
            }
            catch
            {
                MessageBox.Show("Неверный ввод чисел/Не заполнены поля");
            }
        }

        private void Achislo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != "-")
                    if (double.Parse(textBox.Text) == 0)
                        textBox.Text = null;
            }
            catch
            {
                Achislo.Text = null;
                MessageBox.Show("Неправильно A");
            }
        }

        private void Bchislo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Bchislo.Text != "-")
                    double.Parse(Bchislo.Text);
            }
            catch
            {
                Bchislo.Text = null;
                MessageBox.Show("Неправильно B");
            }
        }

        private void Cchislo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (Cchislo.Text != "-")
                    double.Parse(Cchislo.Text);
            }
            catch
            {
                Cchislo.Text = null;
                MessageBox.Show("Неправильно C");
            }
        }
    }
}
