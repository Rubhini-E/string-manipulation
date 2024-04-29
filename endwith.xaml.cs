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
    /// Interaction logic for endwith.xaml
    /// </summary>
    public partial class endwith : Page
    {
        public endwith()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtval.Text.ToString();
            string con = txtrem.Text.ToString();

            int mindex = name.LastIndexOf(con);
            if (mindex != -1)
            {
                MessageBox.Show("text ends with " + con);
            }
            else
            {
                MessageBox.Show("text does not ends with " + con);
            }
        }
    }
}
