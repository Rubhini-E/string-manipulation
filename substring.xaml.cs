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
    /// Interaction logic for substring.xaml
    /// </summary>
    public partial class substring : Page
    {
        public substring()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtval.Text.ToString();


            int nindex = name.IndexOf(txtrem.Text);
            string value = name.Substring(nindex);

            MessageBox.Show(value);

        }
    }
}
