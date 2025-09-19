using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Sistema_de_Gestión_para_un__Bando_de_Sangre.Clases;
using Sistema_de_Gestión_para_un__Bando_de_Sangre.Windows;
namespace Sistema_de_Gestión_para_un__Bando_de_Sangre
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BnLogin_Click(object sender, RoutedEventArgs e)
        {
            Usuarios us = new Usuarios();
            us.usuario = txtUsuario.Text;
            us.pass = txtPass.Password;

            using (SqlConnection login = ConnectioDB.DBconnection())
            {
                string query = $"select * from Usuarios where Usuario = '{us.usuario}' and Pass = '{us.pass}'";
                SqlCommand con = new SqlCommand(query, login);
                SqlDataReader reader = con.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows == true)
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                        this.Hide();
                        //MessageBox.Show("Hola");
                    }

                }
                reader.Close();
            }
            
        }
    }
}
