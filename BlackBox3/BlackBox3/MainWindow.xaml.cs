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

namespace BlackBox3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int x, x1, x2, x3, y, y1, y2, y3;
            double a, b, c, d, t, f;
            y = Convert.ToInt32(Y.Text);
            try
            {
                x = Convert.ToInt32(X.Text);
                x1 = Convert.ToInt32(X1.Text);
                x2 = Convert.ToInt32(X2.Text);
                x3 = Convert.ToInt32(X3.Text);
                y1 = Convert.ToInt32(Y1.Text);
                y2 = Convert.ToInt32(Y2.Text);
                y3 = Convert.ToInt32(Y3.Text);
                a = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
                b = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                c = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
                d = Math.Sqrt((x3 - x) * (x3 - x) + (y3 - y) * (y3 - y));

                t = Math.Sqrt((x - x2) * (x - x2) + (y - y2) * (y - y2));
                f = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

                if ((a == b) && (b == c) && (c == d) && (d == a) && (t != f))
                    Otvet.Content = "Ответ: Ромб";
                else if (((a == c) && (b == d)) && (t != f))
                    Otvet.Content = "Ответ: Параллелограмм";
                else if ((a == b) && (b == c) && (c == d) && (d == a))
                    Otvet.Content = "Ответ: Квадрат";
                else if ((a == c) && (b == d))
                    Otvet.Content = "Ответ: Прямоугольник";
                else if (((y3 == y2) && (y1 == y) && (x3 != x) && (x1 != x2) && (b == d)) || ((x == x3) && (x1 == x2) && (y != y1) && (y2 != y3) && (a == c)))
                    Otvet.Content = "Ответ: Равнобедренная трапеция";
                else if (((y3 == y2) && (y1 == y) && (((x3 == x) && (x1 != x2)) || ((x3 != x) && (x1 == x2)))) || ((x == x3) && (x1 == x2) && (((y == y1) && (y2 != y3)))
                    || ((y != y1) && (y2 == y3))))
                    Otvet.Content = "Ответ: Прямоугольная трапеция";
                else if (((y3 == y2) && (y1 == y) && (x3 != x) && (x1 != x2)) || ((x == x3) && (x1 == x2) && (y != y1) && (y2 != y3)))
                    Otvet.Content = "Ответ: Трапеция общего вида";
                else
                    Otvet.Content = "Ответ: Четырехугольник общего вида";
            }
            catch
            {
                MessageBox.Show("Введите значения");
            }
        }
        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != "-")
                    double.Parse(textBox.Text);

            }

            catch
            {
                textBox.Text = null;
            }
        }
        private void Y3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double.Parse(Y3.Text);
            }
            catch
            {
                Y3.Text = null;
            }
        }
    }
}
