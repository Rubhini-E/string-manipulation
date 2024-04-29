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
    /// Interaction logic for startwith.xaml
    /// </summary>
    public partial class startwith : Page
    {
        public startwith()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtval.Text.ToString();
            string con = txtrem.Text.ToString();

            int mindex = name.IndexOf(con);
            if (mindex == 0)
            {
                MessageBox.Show("text starts with " + con);
            }
            else
            {
                MessageBox.Show("text does not start with " + con);
            }
        }
    }
}
