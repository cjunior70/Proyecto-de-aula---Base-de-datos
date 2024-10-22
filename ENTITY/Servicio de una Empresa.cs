using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Servicio_de_una_Empresa
    {
        public int codigo {  get; set; }
        public int codigo_del_servicio { get; set; }
        public int codigo_de_la_empresa { get; set; }

        public Servicio_de_una_Empresa()
        {
        }

        public Servicio_de_una_Empresa(int codigo, int codigo_del_servicio, int codigo_de_la_empresa)
        {
            this.codigo = codigo;
            this.codigo_del_servicio = codigo_del_servicio;
            this.codigo_de_la_empresa = codigo_de_la_empresa;
        }
    }
}
