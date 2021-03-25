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

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long point = 110;
        static int one_cl = 1;

        double sold_b1 = 10 + 10 * (30 + one_cl * 0.2);
        double sold_b2 = 20 + 20 * (60 + one_cl * 0.4);
        double sold_b3 = 30 + 30 * (90 + one_cl * 0.6);
        double sold_b4 = 40 + 40 * (120 + one_cl * 0.8);
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Update()
        {
            lbPoints.Content = "Очков всего :" + point;
            lbPPC.Content = "Очков за нажатие :" + one_cl;
            btUp1.Content = (sold_b1).ToString();
            btUp2.Content = (sold_b2).ToString();
            btUp3.Content = (sold_b3).ToString();
            btUp4.Content = (sold_b4).ToString();

        }

        private void img1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += one_cl;
            Update();
        }

        private void btUp1_Click(object sender, RoutedEventArgs e)
        {
            if(point >= (sold_b1))
            {
                point -= Convert.ToInt64(Math.Round(sold_b1));
                one_cl += 3;
                Update();
            }
            else
            {
                MessageBox.Show("Не хватает очков!");
            }
        }

        private void btUp2_Click(object sender, RoutedEventArgs e)
        {
            if(point >= (sold_b2))
            {
                point -= Convert.ToInt64(Math.Round(sold_b2));
                one_cl += 6;
                Update();
            }
            else
            {
                MessageBox.Show("Не хватает очков!");
            }
        }

        private void btUp3_Click(object sender, RoutedEventArgs e)
        {
            if(point >= (sold_b3))
            {
                point -= Convert.ToInt64(Math.Round(sold_b3));
                one_cl += 9;
                Update();
            }
        }

        private void btUp4_Click(object sender, RoutedEventArgs e)
        {
            if(point >= (sold_b4))
            {
                point -= Convert.ToInt64(Math.Round(sold_b4));
                one_cl += 12;
                Update();
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
