using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema_de_Gestión_para_un__Bando_de_Sangre.Clases
{
    public class ConnectioDB
    {
        public static SqlConnection DBconnection()
        {
            SqlConnection acceso = new SqlConnection("Data Source=DESKTOP-5F1MSU0;Initial Catalog=BancoSangre;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                acceso.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("error con la base de datos", "Informacion", MessageBoxButton.OK);
            }
            return acceso;
        }
    }
}
