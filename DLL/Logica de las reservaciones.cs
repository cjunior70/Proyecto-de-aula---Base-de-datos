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
    public class logica_de_las_reservaciones
    {

        //Conexion general par el ingreso y registro de las personas nuevas
        Datos_login datos_de_conexion = new Datos_login();

        Funciones_de_la_reservacion funciones_De_La_Reservacion = new Funciones_de_la_reservacion();

        //Funcion para guardar una reservacion
        public Boolean registrar_una_reservacion(Datos_login datos_de_conexion, Reservacion datos_de_una_reservacion)
        {
            
            Boolean existencia;

            existencia = funciones_De_La_Reservacion.Ingresar_Una_reservacion(datos_de_conexion, datos_de_una_reservacion);

            return existencia;

        }

        //Funcion para buscar una reservacion
        public DataTable buscar_una_reservacion(Datos_login datos_de_conexion, Reservacion datos_de_la_reservacion) 
        {
            DataTable datos;

            datos = funciones_De_La_Reservacion.Consultar_Una_Reservacion(datos_de_conexion, datos_de_la_reservacion);

            return datos;

        }

        //Funcion para actualizar una reservacion
        public Boolean actualizar_reservacion(Datos_login datos_de_conexion, Reservacion datos_de_la_reservacion)
        {

            Boolean confirmacion;

            confirmacion = funciones_De_La_Reservacion.Modificar_datos_una_reservacion(datos_de_conexion, datos_de_la_reservacion);

            return confirmacion;

        }

        //Funcion para traer todas las reservaciones
        public DataTable todas_las_reservaciones(Datos_login datos_de_conexion)
        {
            DataTable lista_de_reservaciones;

            lista_de_reservaciones = funciones_De_La_Reservacion.Consultar_Todas_las_reservaciones(datos_de_conexion);

            return lista_de_reservaciones;

        }

        //Funcion para eliminar una reservacion
        public Boolean eliminar_reservacion(Datos_login datos_de_conexion, Reservacion datos_de_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_De_La_Reservacion.borrar_una_reservacion(datos_de_conexion,datos_de_la_reservacion);

            return confirmacion;

        }

    }
}
