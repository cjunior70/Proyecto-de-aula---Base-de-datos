using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Servicio_de_un_empleado
    {
        public int codigo {  get; set; }
        public int codigo_del_servicio { get; set; }
        public int codigo_del_empleado {  get; set; }

        public Servicio_de_un_empleado()
        {
        }

        public Servicio_de_un_empleado(int codigo, int codigo_del_servicio, int codigo_del_empleado)
        {
            this.codigo = codigo;
            this.codigo_del_servicio = codigo_del_servicio;
            this.codigo_del_empleado = codigo_del_empleado;
        }
    }
}
