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
    /// Interaction logic for contains.xaml
    /// </summary>
    public partial class contains : Page
    {
        public contains()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtval.Text.ToString();
            string con = txtcon.Text.ToString();

            bool mindex = name.Contains(con);
            if(mindex == false)
            {
                MessageBox.Show("text does not contain " + con);
            }
            else
            {
                MessageBox.Show("text contain " + con );
            }


        }
    }
}
