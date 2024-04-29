using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace string_mthd
{
    /// <summary>
    /// Interaction logic for replace.xaml
    /// </summary>
    public partial class replace : Page
    {
        public replace()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string name = txtval.Text.ToString();
            
            char replace = Convert.ToChar(txtrep.Text);
            char with = Convert.ToChar(txtwith.Text);

            string value = name.Replace(replace,with);

            MessageBox.Show(value);
        }
    }
}
