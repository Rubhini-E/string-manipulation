
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
using System.Xml.Linq;

namespace string_mthd
{
    /// <summary>
    /// Interaction logic for remove.xaml
    /// </summary>
    public partial class remove : Page
    {
        public remove()
        {
            InitializeComponent();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = txtval.Text.ToString();
            
          
            int nindex = name.IndexOf(txtrem.Text);
            string value = name.Remove(nindex);

            MessageBox.Show(value);




        }
    }
}
