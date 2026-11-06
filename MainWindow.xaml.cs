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

namespace תכונת_לומדה_6._11._26
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

        private void Start(object sender, RoutedEventArgs e)
        {
            targil.Visibility = Visibility.Visible;
            start.Visibility = Visibility.Collapsed;

            int n1 = new Random().Next(1, 11);
            num1.Text = n1.ToString();
            int n2 = new Random().Next(1, 11);
            num2.Text = n2.ToString();
            int peula = new Random().Next(1, 5);
        }
    }
}