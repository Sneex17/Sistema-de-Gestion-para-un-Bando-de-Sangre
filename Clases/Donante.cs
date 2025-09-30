using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_para_un__Bando_de_Sangre.Clases
{
    public class Donante
    {
        public int IdDonante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad {  get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public string Telefono { get; set; }
        public string Provincia { get; set; }
        public string Sector {  get; set; }
        public string Direccion { get; set; }

        //Metodo para saber la edad
        public static int CalcularEdad(Donante donante)
        {
            DateTime FechaHoy = DateTime.Now;
            donante.Edad = FechaHoy.Year - donante.Nacimiento.Year;
            if(FechaHoy.Month < donante.Nacimiento.Month || 
                (FechaHoy.Month == donante.Nacimiento.Month && FechaHoy.Day < donante.Nacimiento.Day))
            {
                donante.Edad--;
            }
            return donante.Edad;
        }

    }
}
