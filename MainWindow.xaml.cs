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

namespace ISRPO_Palashicheva_PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TB1_MouseDown1(object sender, MouseEventArgs e)
        {
            TB1.Text = "1";
        }

        private void TB2_MouseDown2(object sender, MouseEventArgs e)
        {
            TB2.Text = "2";
        }


        private void TB3_MouseDown3(object sender, MouseEventArgs e)
        {
            TB3.Text = "3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TB1.Text = "";
            TB2.Text = "";
            TB3.Text = "";
        }
    }
}
