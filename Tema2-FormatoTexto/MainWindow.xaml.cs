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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultadoTextoBlock.Text = inputTextBox.Text;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(rojoRadioButton.IsChecked == true)
            {
                resultadoTextoBlock.Foreground = Brushes.Red;
            }
            else if(azulRadioButton.IsChecked == true)
            {
                resultadoTextoBlock.Foreground = Brushes.Blue;
            }
            else if(verdeRadioButton.IsChecked == true)
            {
                resultadoTextoBlock.Foreground = Brushes.Green;
            }
        }

        private void EstiloCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(negritaCheckBox.IsChecked == true)
            {
                resultadoTextoBlock.FontWeight = FontWeights.Bold;
            }
            if(cursivaCheckBox.IsChecked == true)
            {
                resultadoTextoBlock.FontStyle = FontStyles.Italic;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (negritaCheckBox.IsChecked == false)
            {
                resultadoTextoBlock.FontWeight = FontWeights.Normal;
            }
            if (cursivaCheckBox.IsChecked == false)
            {
                resultadoTextoBlock.FontStyle = FontStyles.Normal;
            }
        }
    }
}
