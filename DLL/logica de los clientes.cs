using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace DLL
{
    public class logica_de_los_clientes
    {

        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        //Funcion para el ingreso de datos de un cliente
        public Boolean registro_de_cliente(Cliente datos_de_cliente)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

           //Variabale para la confirmacion de ninguno error ajeno
           Boolean confirmacion;

           //Datos de conexion del usuario administrdor para poder ingresar los datos
           datos_de_conexion.usuario = "admin";
  
           datos_de_conexion.constraseña = "admin";

           confirmacion = funciones_Del_Cliente.Ingresar_Un_Cliente(datos_de_conexion, datos_de_cliente);

           Console.WriteLine("situacion : " + confirmacion);

            return confirmacion;

        }

        //Funcion para poder consultar datos personales
        public DataTable consulta_De_datos_personales(Cliente datos_de_cliente)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_Del_Cliente.Consultar_Un_Cliente(datos_de_conexion, datos_de_cliente);

            return existencia;
        }

        //Funcion para consultar todos los clientes
        public DataTable consultar_todo_los_cliente()
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_Del_Cliente.Consultar_Clientes(datos_de_conexion);

            return existencia;
        }

        //Funcion para actualizar datos de un cliente
        public Boolean actualizar_datos_de_un_cliente(Cliente datos_nuevo_Del_cliente)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_Del_Cliente.Modificar_datos_del_cliente(datos_de_conexion, datos_nuevo_Del_cliente);

            return existencia;
        }

        //Funcion para borrar datos de un cliente
        public Boolean borrar_datos_de_un_cliente(Cliente datos_nuevo_Del_cliente)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_cliente funciones_Del_Cliente = new Funciones_del_cliente();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_Del_Cliente.borrar_un_cliente(datos_de_conexion, datos_nuevo_Del_cliente);

            return existencia;
        }



    }
}
