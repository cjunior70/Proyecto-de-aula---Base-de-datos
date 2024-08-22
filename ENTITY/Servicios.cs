using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Servicios
    {

        //Datos basicos de los servicios
        public string codigo { get; set; }
        public string nombre_del_servicio { get; set; }
        public int precio { get; set; }
        public Timer tiempo_promedio { get; set; }

        //Constructor para la entrada de las clase
        public Servicios()
        {
        }

        //Constructor de los datos de los servicios
        public Servicios(string codigo, string nombre_del_servicio, int precio, Timer tiempo_promedio)
        {
            this.codigo = codigo;
            this.nombre_del_servicio = nombre_del_servicio;
            this.precio = precio;
            this.tiempo_promedio = tiempo_promedio;
        }

    }
}
