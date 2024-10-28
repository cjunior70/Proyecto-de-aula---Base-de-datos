using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace DLL
{
    public class Funciones_de_registros_a_la_aplicacion
    {
        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        //Funcion para el ingreso de datos de un usuario 
        public Boolean registro_de_usuario(Usuario datos_de_usuario)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_Usuario=new Funciones_del_usuario();

            //Variabale para la confirmacion de ninguno error ajeno
            Boolean confirmacion;

            confirmacion = funciones_Del_Usuario.Ingresar_Un_Usuario(datos_de_conexion,datos_de_usuario);

            return confirmacion;

        }

        //Funcion para el ingreso de datos de un cliente
        public Boolean registro_de_cliente(Cliente datos_de_cliente)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

            //Variabale para la confirmacion de ninguno error ajeno
            Boolean confirmacion;

            confirmacion = funciones_Del_Cliente.Ingresar_Un_Cliente(datos_de_conexion, datos_de_cliente);

            return confirmacion;

        }

    }
}
