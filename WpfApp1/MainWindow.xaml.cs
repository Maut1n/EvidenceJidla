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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zbozi> Zbozis { get; set; }
        public MainWindow()
        {
            Zbozis = new();
            InitializeComponent();
            Seznam.ItemsSource = Zbozis;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pridat dialog = new(Zbozis);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            Seznam.ItemsSource = null;
            Seznam.ItemsSource = Zbozis;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Zbozi? Hledany = Seznam?.SelectedItem as Zbozi;
            var volba = MessageBox.Show($"Odebrat{Hledany.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Zbozis.Remove(Hledany);
                Seznam.ItemsSource = null;
                Seznam.ItemsSource = Zbozis;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zbozi? Hledany = Seznam?.SelectedItem as Zbozi;
            if (Hledany != null)
            {
                DialogEdit edit = new DialogEdit(Hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }

        }
    }
}
    