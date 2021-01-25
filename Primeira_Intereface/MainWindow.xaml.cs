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
using System.Xaml;

namespace Primeira_Intereface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SlideGrid.Visibility = Visibility.Hidden;
            TextBoxesGrid.Visibility = Visibility.Hidden;
            JuntaNomeESobreNome = new JunteNomes { Nome = "Michael", SobreNome = "Lima" };
            this.DataContext = JuntaNomeESobreNome;
        }

        internal JunteNomes JuntaNomeESobreNome;

        private void BtBindingSlide_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxesGrid.Visibility == Visibility.Visible)
            {
                TextBoxesGrid.Visibility = Visibility.Hidden;
                BtBindiningTextBox.Content = "Show TextBoxes";
            }

            if (SlideGrid.Visibility == Visibility.Hidden)
            {
                SlideGrid.Visibility = Visibility.Visible;
                BtBindingSlide.Content = "Hide Slide";
            }
            else
            {
                SlideGrid.Visibility = Visibility.Hidden;
                BtBindingSlide.Content = "Show Slide";
            }
        }

        private void BtBindiningTextBox_Click(object sender, RoutedEventArgs e)
        {
            if (SlideGrid.Visibility == Visibility.Visible)
            {
                SlideGrid.Visibility = Visibility.Hidden;
                BtBindingSlide.Content = "Show Slide";
            }

            if (TextBoxesGrid.Visibility == Visibility.Hidden)
            {
                TextBoxesGrid.Visibility = Visibility.Visible;
                BtBindiningTextBox.Content = "Hide TextBoxes";
            }
            else
            {
                TextBoxesGrid.Visibility = Visibility.Hidden;
                BtBindiningTextBox.Content = "Show TextBoxes";
            }
        }
    }
}
