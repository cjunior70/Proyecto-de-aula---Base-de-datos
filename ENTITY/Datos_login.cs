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

        public Datos_login()
        {
        }

        public Datos_login(string usuario, string constraseña)
        {
            this.usuario = usuario;
            this.constraseña = constraseña;
        }

    }
}
