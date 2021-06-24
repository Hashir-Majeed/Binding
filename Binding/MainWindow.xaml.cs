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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Board b;

        public MainWindow()
        {
            InitializeComponent();
            b = new Board();
            DataContext = b;
        }







        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // b.setColour(0);
            b.ColourText = "White";


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // b.setColour(1);
            b.ColourText = "Yellow";
            //  b.setColourT("Yellow");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            b.ColourText = "Red";
        }
    }
}