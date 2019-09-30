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


namespace RatonTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdo_TextBox.Background = Brushes.Green;
            
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdo_TextBox.Background = Brushes.White;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            BotonDerecho_TextBox1.Background = Brushes.Green;
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            BotonDerecho_TextBox1.Background = Brushes.White;
        }

        private void Mayusculas_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mayusculas_TextBox.Text = mayusculas_TextBox.Text.ToUpper();
        }

        private void Mayusculas_TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Mayusculas_TextBox_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Ayuda_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ayuda_TextBox.Text = "Ayuda";
        }
    }
}
