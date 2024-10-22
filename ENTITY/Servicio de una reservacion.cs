using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Servicio_de_una_reservacion
    {
        public int codigo { get; set; }
        public int codigo_de_servicio { get; set; }
        public int codigo_de_reservacion { get; set; }

        public Servicio_de_una_reservacion()
        {
        }

        public Servicio_de_una_reservacion(int codigo, int codigo_de_servicio, int codigo_de_reservacion)
        {
            this.codigo = codigo;
            this.codigo_de_servicio = codigo_de_servicio;
            this.codigo_de_reservacion = codigo_de_reservacion;
        }

    }
}
