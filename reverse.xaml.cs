﻿using System;
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
    /// Interaction logic for reverse.xaml
    /// </summary>
    public partial class reverse : Page
    {
        public reverse()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] name = txtval.Text.ToCharArray();
            int namelength = name.Length;
            string rev = "";

            for(int i=namelength-1;i>=0;i--)
            {
                rev += name[i].ToString();
            }
            txtrem.Text = rev;
        }
    }
}
