using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Ubicacion
    {

        //Datos basicos de la ubicacion
        public string codigo { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        //Constructor para acceso a la clase
        public Ubicacion()
        {
        }

        //Constructor para los datos basicos
        public Ubicacion(string codigo, double latitud, double longitud)
        {
            this.codigo = codigo;
            this.latitud = latitud;
            this.longitud = longitud;
        }

    }
}
