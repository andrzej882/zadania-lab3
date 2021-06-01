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

namespace WpfApp1
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

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtSuma_Click(object sender, RoutedEventArgs e)
        {

            try
            {
               
                float x = float.Parse(TextBox1.Text);
                float y = float.Parse(TextBox2.Text);

                LabelWynik.Content = "Suma" + x + " + " + y + " = " + (x + y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podaj dobre dane");
            }
        }

        private void BtIloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                float x = float.Parse(TextBox1.Text);
                float y = float.Parse(TextBox2.Text);

                LabelWynik.Content = "Iloczyn " + x + " * " + y + " = " + (x * y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podaj dobre dane");
            }
        }

        private void BtRoznica_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                float x = float.Parse(TextBox1.Text);
                float y = float.Parse(TextBox2.Text);

                LabelWynik.Content = "Roznica " + x + " - " + y + " = " + (x-y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podaj dobre dane");
            }
        }

        private void BtIloraz_Click(object sender, RoutedEventArgs e)
        {

            
            {
               
                float x = float.Parse(TextBox1.Text);
                float y = float.Parse(TextBox2.Text);
                if (y > 0)
                {
                    LabelWynik.Content = "Iloraz " + x + " / " + y + " = " + (x / y).ToString();
                }
                else
                {
                    
                    MessageBox.Show("Nie mozesz dzielic prezz 0");
                    
                }
            }
            
        }
         
            }
        }
    

