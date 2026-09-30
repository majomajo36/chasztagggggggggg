using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GrafikaiZdarzenia
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void obraz1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            obraz.Source = new BitmapImage(new Uri("pack://application:,,,/grafika/1.jpg"));
        }
        private void obraz2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            obraz.Source = new BitmapImage(new Uri("pack://application:,,,/grafika/2.jpg"));
        }
        private void obraz3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            obraz.Source = new BitmapImage(new Uri("pack://application:,,,/grafika/3.jpg"));
        }
        private void obraz4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            obraz.Source = new BitmapImage(new Uri("pack://application:,,,/grafika/pytajnik.jpg"));
        }


    }
}