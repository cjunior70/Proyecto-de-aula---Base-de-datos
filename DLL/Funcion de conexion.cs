using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace DLL
{
    public class Funcion_de_conexion
    {

        public Boolean conexion(Datos_login datos_de_conexion)
        {
            Conexion_General conexion=new Conexion_General();

            Boolean confirmacion;

            confirmacion = conexion.Conexion_con_la_base(datos_de_conexion);

            return confirmacion;

        }

    }
}
