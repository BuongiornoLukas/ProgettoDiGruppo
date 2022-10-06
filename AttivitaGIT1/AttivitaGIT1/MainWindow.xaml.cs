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

namespace AttivitaGIT1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int[] v = new int[10];

        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();  

            for(int i= 0; i < 10; i++)
                v[i] = rnd.Next(0,100);
        }
        
        //Button per il calcolo della media
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double somma = 0;

            for (int j = 0; j < 10; j++)
                somma += v[j];

            lblMedia.Content = somma / 10;

            
        }
    }
}
