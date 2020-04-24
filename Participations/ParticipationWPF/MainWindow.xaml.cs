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

namespace ParticipationWPF
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
            //completed on Shawn Ross's computer as mine does not run VirtualStudio
            string name = txtName.Text;
            string favColor = txtColor.Text;
            string myFavColor = "green";
            if (favColor.ToLower() == myFavColor)
            {
                MessageBox.Show("Wow! We have the same favorite color!");
            }
            else
            {
                MessageBox.Show($"{name} that is really cool, I never would have expected your favorite color to be {favColor}");
               

            }
        }
    }
}
