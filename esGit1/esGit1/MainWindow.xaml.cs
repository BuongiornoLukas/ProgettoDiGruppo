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

namespace Attivita_1GIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] v = new double[10];
        public MainWindow()
        {
            InitializeComponent();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
                v[i] = r.Next(0, 100);
        }
        // button per il calcolo della media
        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            double somma = 0;

            for (int i = 0; i < 10; i++)
                somma += v[i];

            lblMedia.Content = somma / 10;
        }

        //button per il calcolo del minimo
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            double min = v[0];

            for (int i = 1; i < 10; i++)
            {
                if (v[i] < min)
                    min = v[i];
            }

            lblMin.Content = min;
        }
    }
}
