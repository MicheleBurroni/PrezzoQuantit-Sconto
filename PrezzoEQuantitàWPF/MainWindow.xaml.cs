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

namespace PrezzoEQuantitàWPF
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
        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrezzo.Text != "" && txtQuantità.Text != "" && txtSconto.Text != "")
            {
                try
                {
                    double p = double.Parse(txtPrezzo.Text);
                    int q = int.Parse(txtQuantità.Text);
                    double x = double.Parse(txtSconto.Text);
                    double tot = p * q;
                    if (x > 100 || x < 0)
                    {
                        MessageBox.Show("Lo sconto che hai inserito non è valido!");
                    }
                    else
                    {
                        if (q > 20)
                        {
                            double sconto = tot / 100 * x;
                            iblStampa.Content = sconto;
                        }
                        else
                        {
                            iblStampa.Content = tot;
                        }
                    }
                }
                catch (Exception ex)
                {
                    iblStampa.Content = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Nessun dato inserito!", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
