using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Datos_login
    {
        public string usuario { get; set; }
        public string constraseña { get; set; }

        public string cedula_del_usuario {  get; set; } 

        public char quien_esta { get; set; }

        public Datos_login()
        {
        }

        public Datos_login(string usuario, string constraseña, string cedula_del_usuario, char quien_esta)
        {
            this.usuario = usuario;
            this.constraseña = constraseña;
            this.cedula_del_usuario = cedula_del_usuario;
            this.quien_esta = quien_esta;
        }
    }
}
