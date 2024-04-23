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
    /// Interakční logika pro Pridat.xaml
    /// </summary>
    public partial class Pridat : Window
    {
        List<Zbozi> _zbozi;
        public Pridat(List<Zbozi> zbozi)
        {
            InitializeComponent();
            _zbozi = zbozi; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nazev = ProNazev.Text;
            string cena = ProCena.Text;
            string pocet = ProPocet.Text;
            string id = ProID.Text;

            



            this.Close();
        }
    }
}
