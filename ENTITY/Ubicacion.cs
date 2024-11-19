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
        public int codigo { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }

        //Constructor para acceso a la clase
        public Ubicacion()
        {
        }


        //Constructor para los datos basicos
        public Ubicacion(int codigo, string latitud, string longitud)
        {
            this.codigo = codigo;
            this.latitud = latitud;
            this.longitud = longitud;
        }


    }
}
