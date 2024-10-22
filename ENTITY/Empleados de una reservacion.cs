using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Empleados_de_una_reservacion
    {
        public int codigo {  get; set; }
        public int codigo_de_reservacion { get; set; }
        public int codigo_de_empleado { get; set; }

        public Empleados_de_una_reservacion()
        {
        }

        public Empleados_de_una_reservacion(int codigo, int codigo_de_reservacion, int codigo_de_empleado)
        {
            this.codigo = codigo;
            this.codigo_de_reservacion = codigo_de_reservacion;
            this.codigo_de_empleado = codigo_de_empleado;
        }
    }
}
