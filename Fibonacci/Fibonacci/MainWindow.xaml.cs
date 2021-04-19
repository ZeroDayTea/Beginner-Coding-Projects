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

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Fibonacci()
        {
            int a = 1;
            int b = 1;
            int temp;

            for (int i = 0; i < 50; i++)
            {
                txtTest.Text = txtTest.Text + " " + a.ToString();
                temp = a + b;
                a = b;
                b = temp;
            }
        }

        private void btnPatryk_Click(object sender, RoutedEventArgs e)
        {
            Fibonacci();
        }
    }
}
