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

namespace WpfApplication
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double Input1, Input2;

            try
            {
                Input1 = Convert.ToDouble(txtInput1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input1: " + ex.Message, "Error");
                return;
            }

            try
            {
                Input2 = Convert.ToDouble(txtInput2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input2: " + ex.Message, "Error");
                return;
            }

            txtResult.Text = (Input1 + Input2).ToString();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            double Input1, Input2;

            try
            {
                Input1 = Convert.ToDouble(txtInput1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input1: " + ex.Message, "Error");
                return;
            }

            try
            {
                Input2 = Convert.ToDouble(txtInput2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input2: " + ex.Message, "Error");
                return;
            }

            txtResult.Text = (Input1 - Input2).ToString();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            double Input1, Input2;

            try
            {
                Input1 = Convert.ToDouble(txtInput1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input1: " + ex.Message, "Error");
                return;
            }

            try
            {
                Input2 = Convert.ToDouble(txtInput2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input2: " + ex.Message, "Error");
                return;
            }

            txtResult.Text = (Input1 * Input2).ToString();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            double Input1, Input2;

            try
            {
                Input1 = Convert.ToDouble(txtInput1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input1: " + ex.Message, "Error");
                return;
            }

            try
            {
                Input2 = Convert.ToDouble(txtInput2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Input2: " + ex.Message, "Error");
                return;
            }

            txtResult.Text = (Input1 / Input2).ToString();
        }

    }
}
