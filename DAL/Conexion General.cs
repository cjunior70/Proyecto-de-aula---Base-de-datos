using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class Conexion_General
    {

        //Funcion para poder saber si el usuario existe o no
        public Boolean Conexion_con_la_base(Datos_login datos)
        {
            //Cadena de conexion para ingresar el nombre de usuario y su contraseña
            string conexion = $"DATA SOURCE=localhost:1521/xepdb1;PASSWORD={datos.constraseña};USER ID={datos.usuario};";

            //Instancia de la clase de oracleconection para la conexion a la base de datos de oracle
            OracleConnection ora = new OracleConnection(conexion);
            try
            {
                //Abir conexion
                ora.Open();

                //El usuario existe
                return true;
            }
            catch (Exception)
            {
                //El usuario no existe
                return false;
            }
        }

    }
}
