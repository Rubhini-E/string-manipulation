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

namespace string_mthd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        remove opage1;
        substring opage2;
        replace opage3;
        contains opage4;
        startwith opage5;
        endwith opage6;
        reverse opage7;

        public MainWindow()
        {
            InitializeComponent();
            opage1 = new remove();
            opage2 = new substring();
            opage3 = new replace();
            opage4 = new contains();
            opage5 = new startwith();
            opage6 = new endwith();
            opage7 = new reverse();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage2;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage7;
        }
    }
}
