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

namespace BlackBox2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
                c = Convert.ToInt32(Cs.Text);
            try
            {
                a = Convert.ToInt32(As.Text);
                b = Convert.ToInt32(Bs.Text);

                if (c == (b & a))
                    Otvet.Content = "Треугольник равносторонний";
                else if ((a == b) || (b == c) || (c == a))
                    Otvet.Content = "Треугольник равнобедренный";
                else if ((b == (a * a - 1) / 2) || (c == (a * a - 1) / 2))
                    Otvet.Content = "Треугольник прямоугольный";
                else if (c != (b & a))
                    Otvet.Content = "Треугольник разносторонний";
            }
            catch
            {
                MessageBox.Show("Введите значения");
            }
        }

        private void As_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (int.Parse(textBox.Text) == 0)
                    textBox.Text = null;

            }

            catch
            {
                textBox.Text = null;
            }
        }

        private void Bs_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (int.Parse(textBox.Text) == 0)
                    textBox.Text = null;

            }

            catch
            {
                textBox.Text = null;
            }
        }

        private void Cs_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double.Parse(Cs.Text);
            }
            catch
            {
                Cs.Text = null;
            }
        }
    }
}
