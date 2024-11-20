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

namespace kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String number = number1.Text;
            //int numberN1 = int.Parse(number1.Text);
            int numberN1;
            int numberN2;
            int value = 0;
            if(int.TryParse(number1.Text, out numberN1) && int.TryParse(number2.Text, out numberN2)){
                value = numberN1 + numberN2;
                MessageBox.Show("Wynik dodawania: " + value.ToString(), "Not really interesting information", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("Your computer is going to defenestrate itself... Don't turn your computer off...", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
