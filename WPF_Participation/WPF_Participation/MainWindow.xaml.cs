//Jatin Davis
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

namespace WPF_Participation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, color;
            name = UserNameTxtBox.Text;
            color = FavoriteColorTxtBox.Text;

            if (color == "Blue" )
            {
                MessageBox.Show("We have the same favorite color!");
            }
            else
            {
                MessageBox.Show($"{name} that is really cool. I would have never expected your favorite color to be {color}");
            }
        }
    }
}
