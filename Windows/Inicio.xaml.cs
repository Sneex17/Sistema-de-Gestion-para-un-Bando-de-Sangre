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

namespace Sistema_de_Gestión_para_un__Bando_de_Sangre.Windows
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void RgDonante_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DtDonante_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuInformacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuRgDonante_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuCompatible_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuTypeSangre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
        }
    }
}
