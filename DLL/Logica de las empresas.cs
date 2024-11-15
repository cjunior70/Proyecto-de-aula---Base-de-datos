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
    public class logica_de_las_empresas
    {

        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        //Funcion para el ingreso de datos de una empresa
        public Boolean registro_de_una_empresa(Empresa datos_de_la_empresa)
        {

            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_de_la_empresa = new Funciones_de_Empresa();

            //Datos de conexion del usuario administrdor para poder ingresar los datos
            datos_de_conexion.usuario = "admin";

            datos_de_conexion.constraseña = "admin";

            //Variabale para la confirmacion de ninguno error ajeno
            Boolean confirmacion;

           confirmacion = funciones_de_la_empresa.Ingresar_Una_Empresa(datos_de_conexion, datos_de_la_empresa);

           return confirmacion;


        }

        //Funcion para consultar los datos de una empresa con interes o datos de la empresa
        public DataTable consultar_datos_de_una_empresa(Empresa datos_de_la_empresa)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_De_Empresa.Consultar_Una_Empresa(datos_de_conexion, datos_de_la_empresa);

            return existencia;

        }

        //Funcion para consultar todas las empresas registradas
        public DataTable consultar_todas_las_empresas()
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            DataTable existencia;

            existencia = funciones_De_Empresa.Consultar_Todas_las_Empresas(datos_de_conexion);

            return existencia;
        }

        //Funcion para actualizar datos de una empresa 
        public Boolean actualizar_datos_de_la_empresa(Empresa datos_actualizados)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_De_Empresa.Modificar_datos_una_empresa(datos_de_conexion, datos_actualizados);

            return existencia;

        }

        //Funcion para poder borrar datos de la empresa
        public Boolean borrar_datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            //Llamada de la funcion del dal para ingresar a este los datos a la base
            Funciones_de_Empresa funciones_De_Empresa = new Funciones_de_Empresa();

            //Variable para saber la existencia de alguien ya registrado
            Boolean existencia;

            existencia = funciones_De_Empresa.borrar_una_empresa(datos_de_conexion, datos_de_la_empresa);

            return existencia;
        }

    }
}
