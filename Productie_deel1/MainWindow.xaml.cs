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
using System.Collections.Generic;

namespace Productie_deel1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // list om producten bij te houden
        private List<Product> producten = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            VoegToe();
        }

        // methode om een nieuuw product toe te voegen
        private void VoegToe()
        {
            
            if (string.IsNullOrWhiteSpace(txtProduct.Text) || string.IsNullOrWhiteSpace(txtHoeveelheid.Text))
            {
                MessageBox.Show("Gelieve alle velden in te vullen.", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            if (!int.TryParse(txtHoeveelheid.Text, out int hoeveelheid))
            {
                MessageBox.Show("Hoeveelheid moet een geheel getal zijn.", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // mmaak een nieuw product 
            Product nieuwProduct = new Product(txtProduct.Text, hoeveelheid);
            producten.Add(nieuwProduct);

            // toon de gegevens 
            lstProducten.Items.Add(nieuwProduct.Gegevens());

            // maak de tekstvelden
            txtProduct.Clear();
            txtHoeveelheid.Clear();
        }
    }
}