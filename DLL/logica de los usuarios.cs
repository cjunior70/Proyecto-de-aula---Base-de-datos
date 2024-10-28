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
    public class logica_de_los_usuarios
    {

        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        //Funcion para el ingreso de datos de un usuario
        public Boolean registro_de_un_usuario(Usuario datos_de_usuario)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_Usuario = new Funciones_del_usuario();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_Del_Usuario.Consultar_Un_usuario(datos_de_conexion, datos_de_usuario);

            //Si el datatable esta vacia entonces no hay registro guardado con esos datos
            if (existencia == null)
            {

                //Variabale para la confirmacion de ninguno error ajeno
                Boolean confirmacion;

                confirmacion = funciones_Del_Usuario.Ingresar_Un_Usuario(datos_de_conexion, datos_de_usuario);

                return confirmacion;

            }
            else
            {
                //Ya existe un dato con esa informacion
                return false;
            }

        }

        //Funcion para poder consultar datos personales
        public DataTable consulta_De_datos_personales(Usuario datos_de_usuario)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_Usuario = new Funciones_del_usuario();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_Del_Usuario.Consultar_Un_usuario(datos_de_conexion, datos_de_usuario);

            return existencia;
        }

        //Funcion para consultar todos los usuarios
        public DataTable consultar_todo_los_usuarios()
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_Usuario = new Funciones_del_usuario();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_Del_Usuario.Consultar_Usuarios(datos_de_conexion);

            return existencia;
        }

        //Funcion para actualizar datos de un usuario
        public Boolean actualizar_datos_de_un_usuario(Usuario datos_nuevo_Del_Usuario)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_usuario = new Funciones_del_usuario();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_Del_usuario.Modificar_datos_del_usuario(datos_de_conexion, datos_nuevo_Del_Usuario);

            return existencia;
        }

        //Funcion para borrar datos de un usuario
        public Boolean borrar_datos_de_un_usuario(Usuario datos_nuevo_Del_Usuario)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_del_usuario funciones_Del_Usuario = new Funciones_del_usuario();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_Del_Usuario.borrar_un_usuario(datos_de_conexion, datos_nuevo_Del_Usuario);

            return existencia;
        }


    }
}
