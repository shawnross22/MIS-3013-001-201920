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

namespace WPFParticipation
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

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string favcolor = txtFavColor.Text;
            string myfavcolor = "orange";
            if (favcolor.ToLower()==myfavcolor)
            {
                MessageBox.Show($"Congratulations, {name} we have the same favorite color.");
            }
            else
            {
                MessageBox.Show($"{name} that is really cool, I never would have expected your favorite color to be {favcolor}");

            }
        }
    }
}
