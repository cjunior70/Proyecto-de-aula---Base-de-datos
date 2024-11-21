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
    public class logica_de_las_ubicaciones
    {


        Funciones_de_la_ubicacion funciones_De_La_Ubicacion = new Funciones_de_la_ubicacion();

        //Funcion para registar la ubicacion de una empresa
        public Boolean registrar_una_ubicacion(Ubicacion datos_de_la_ubicacion, Datos_login datos_de_conexion)
        {

            Boolean confirmacion;

            confirmacion = funciones_De_La_Ubicacion.Ingresar_Una_Ubicacion(datos_de_conexion, datos_de_la_ubicacion);

            return confirmacion;

        }

        //Funcion para consultar todas las ubicaciones
        public DataTable consultar_todas_las_ubicaciones(Datos_login datos_de_conexion)
        {
            DataTable datos;

            //Datos de conexion del usuario administrdor para poder ingresar los datos
            datos_de_conexion.usuario = "admin";

            datos_de_conexion.constraseña = "admin";

            datos = funciones_De_La_Ubicacion.Consultar_Todas_las_ubicaciones(datos_de_conexion);

            return datos;

        }

        //Funcion para actualizar una ubicacion
        public Boolean actualizar_ubicacion(Ubicacion datos_nuevos_de_la_ubicacion, Datos_login datos_de_conexion)
        {
            Boolean confirmacion;

            confirmacion = funciones_De_La_Ubicacion.Modificar_datos_una_ubicacion(datos_de_conexion, datos_nuevos_de_la_ubicacion);

            return confirmacion;

        }

        //Funcion para borrar una ubicacion
        public Boolean borrar_una_ubicacion(Ubicacion datos_de_la_ubicacion, Datos_login datos_de_conexion)
        {
            Boolean confirmacion;

            confirmacion = funciones_De_La_Ubicacion.borrar_una_ubicacion(datos_de_conexion, datos_de_la_ubicacion);

            return confirmacion;
        }

        //Funcion para buscar una ubicacion por coordenadas
        public DataTable buscar_una_ubicacion(Ubicacion datos_de_la_ubicasion, Datos_login datos_de_conexion)
        {
            DataTable Ubicacion;

            Ubicacion = funciones_De_La_Ubicacion.Consultar_Una_Ubicacion_por_Coordenadas(datos_de_conexion, datos_de_la_ubicasion);

            return Ubicacion;

        }

        //Funcion para buscar una ubicacion por codigo
        public DataTable buscar_una_ubicacion_por_codigo(Ubicacion datos_de_la_ubicasion, Datos_login datos_de_conexion)
        {
            DataTable Ubicacion;

            Ubicacion = funciones_De_La_Ubicacion.Consultar_Una_Ubicacion_por_Codigo(datos_de_conexion, datos_de_la_ubicasion);

            return Ubicacion;

        }

    }
}
