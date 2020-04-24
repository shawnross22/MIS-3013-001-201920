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

namespace WPF_2_Participation
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


        private void rbtnOdd_Checked(object sender, RoutedEventArgs e)
        {
            string numberAsText = txtNumber.Text;
            int number = Convert.ToInt32(numberAsText);

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    lstNumbers.Items.Add(i);
                }
            }
        }

        private void rbtnEven_Checked(object sender, RoutedEventArgs e)
        {
            string numberAsText = txtNumber.Text;
            int number = Convert.ToInt32(numberAsText);

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    lstNumbers.Items.Add(i);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Clear();
            lstNumbers.Items.Clear();
            txtNumber.Focus();
            rbtnOdd.IsChecked = false;
            rbtnEven.IsChecked = false;
        }
    }
}
