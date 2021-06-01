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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkbmw_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void butpokaz_Click(object sender, RoutedEventArgs e)
        
        {
            if (checkbmw.IsChecked == true && checkrodz.IsChecked == true && radiodolna.IsChecked == true) 

            {
                textbox1.Text = "BMW X3";
            }
            else if (checkbmw.IsChecked == true && checkrodz.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "BMW X6";
            }
            else if (checkbmw.IsChecked == true && checksport.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "BMW M4";
            }
            else if (checkbmw.IsChecked == true && checksport.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "BMW E90";
            }
            else if (checkbmw.IsChecked == true && checkbus.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Nie posiadamy tego typu";
            }
            else if (checkbmw.IsChecked == true && checkbus.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Nie posiadamy tego typu";
            }
            else if (checkbmw.IsChecked == true && checkbus.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Nie posiadamy tego typu";
            }
            else if (checkford.IsChecked == true && checkbus.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Ford Transit";
            }
            else if (checkford.IsChecked == true && checkbus.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Ford Tourneo";
            }
            else if (checkford.IsChecked == true && checksport.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Ford Focus RS";
            }
            else if (checkford.IsChecked == true && checksport.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Ford Focus ST";
            }
            else if (checkford.IsChecked == true && checkrodz.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Ford S Max";
            }
            else if (checkford.IsChecked == true && checkrodz.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Ford Kuga";
            }
            else if (checkaudi.IsChecked == true && checkrodz.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Audi RS Q7";
            }
            else if (checkaudi.IsChecked == true && checkrodz.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Audi Q5";
            }
            else if (checkaudi.IsChecked == true && checksport.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Audi A5";
            }
            else if (checkaudi.IsChecked == true && checksport.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Audi RS7";
            }
            else if (checkaudi.IsChecked == true && checksport.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Audi RS7";
            }
            else if (checkaudi.IsChecked == true && checkbus.IsChecked == true && radiogorna.IsChecked == true)

            {
                textbox1.Text = "Nie posiadamy takowego modelu";
            }
            else if (checkaudi.IsChecked == true && checkbus.IsChecked == true && radiodolna.IsChecked == true)

            {
                textbox1.Text = "Nie posiadamy takowego modelu";
            }
            else
            {
                textbox1.Text = "Zaznacz odpowiednie parametry";
            }

        }
    }
}
