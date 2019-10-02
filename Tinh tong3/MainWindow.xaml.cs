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

namespace Tinh_tong3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double n;
        int s1 = 0, s2 = 0, s3 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            txbTong.Text = s1.ToString();
            txbTongchan.Text = s2.ToString();
            txbTongle.Text = s3.ToString();
        }

        private void Total_even_Checked(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i <= Int16.Parse(txtnhap.Text); i++)
            {
                if (i % 2 == 0)
                    s2 += i;
            }
        }

        private void Odd_sum_Checked(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i <= Int16.Parse(txtnhap.Text); i++)
            {
                if (i % 2 != 0)
                    s3 += i;
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Total_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= Int16.Parse(txtnhap.Text); i++)
                s1 += i;
        }
    }
}
