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

        private void Window_MouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && e.RightButton == MouseButtonState.Released)

                BotonIzquierdo_TextBox.Background = Brushes.Green;
            else if (e.LeftButton == MouseButtonState.Pressed && e.RightButton == MouseButtonState.Pressed)
            {
                BotonIzquierdo_TextBox.Background = Brushes.Green;
                BotonDerecho_TextBox1.Background = Brushes.Green;
            }
            else
                BotonDerecho_TextBox1.Background = Brushes.Green;
        }

        private void Window_MouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released && e.RightButton == MouseButtonState.Pressed)
                BotonIzquierdo_TextBox.Background = Brushes.White;
            else if (e.LeftButton == MouseButtonState.Released && e.RightButton == MouseButtonState.Released)
            {
                BotonIzquierdo_TextBox.Background = Brushes.White;
                BotonDerecho_TextBox1.Background = Brushes.White;
            }
            else
                BotonDerecho_TextBox1.Background = Brushes.White;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobre_TextBox.Text = (sender as TextBox).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobre_TextBox.Text = "";
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco_TextBox.Text = (sender as TextBox).Name;
        }

        private void SinVocales_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.A:
                case Key.E:
                case Key.I:
                case Key.O:
                case Key.U:
                    e.Handled = true;
                    break;
                default:

                    break;
            }
        }

        private void QuitarTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco_TextBox.Text = "";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                ayuda_TextBox.Text = "Ayuda";

        }
    }
}
