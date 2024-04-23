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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro DialogEdit.xaml
    /// </summary>
    public partial class DialogEdit : Window
    {
        public Zbozi Z { get; set; }
        public DialogEdit(Zbozi z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Z.Nazev = ProNazev.Text;
            Z.Pocet = ProPocet.Text;
            Z.Cena = ProCena.Text;

            
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
