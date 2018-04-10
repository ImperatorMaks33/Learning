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

namespace WpfApp1
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

        public double c = 0;
        bool bplus = false, bminus = false, bumnoj = false, bdelen = false, bpoint = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 0;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 1;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 2;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 3;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 4;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 5;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 6;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 7;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += 9;
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            texb.Text += ',';
            point.IsEnabled = false;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (texb.Text.Length != 0) 
            texb.Text = texb.Text.Substring(0, texb.Text.Length - 1);
            for (int i = 0; i < texb.Text.Length; i++)
                if (texb.Text[i] == ',')
                {
                    bpoint = true;
                    break;
                }
            if (bpoint == true)
                point.IsEnabled = false;

            else
                point.IsEnabled = true;


        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            texb.Text = "";
        }

        private void delenie_Click(object sender, RoutedEventArgs e)
        {
            bdelen = true;
            c = Convert.ToDouble(texb.Text);
            texb.Text = "";
        }

        private void umnojenie_Click(object sender, RoutedEventArgs e)
        {
            bumnoj = true;
            c = Convert.ToDouble(texb.Text);
            texb.Text = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            bminus = true;
            c = Convert.ToDouble(texb.Text);
            texb.Text = "";
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {


            if (texb.Text == "")

            {
                MessageBox.Show("Введите число","Ошибка");
            }
            else
                if (bplus == true)
                {
                    c += Convert.ToDouble(texb.Text);
                    bplus = false;
                }

                else
            if (bminus == true)
                {
                    c -= Convert.ToDouble(texb.Text);
                    bminus = false;
                }

                else
            if (bumnoj == true)
                {
                    c *= Convert.ToDouble(texb.Text);
                    bumnoj = false;
                }

                else
            if (bdelen == true)
                {
                    c /= Convert.ToDouble(texb.Text);
                    bdelen = false;
                }

                else
                    c = Convert.ToDouble(texb.Text);

                texb.Text = Convert.ToString(c);
                      
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            bplus = true;
            c = Convert.ToDouble(texb.Text);
            texb.Text = "";

        }
    }
}
