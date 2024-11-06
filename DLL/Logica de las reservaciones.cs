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

        Funciones_de_la_reservacion funciones_De_La_Reservacio = new Funciones_de_la_reservacion();

        //Funcion para guardar una reservacion
        public Boolean registrar_una_reservacion(Reservacion datos_de_una_reservacion)
        {
            
            Boolean existencia;

            existencia = funciones_De_La_Reservacio.Ingresar_Una_reservacion(datos_de_conexion, datos_de_una_reservacion);

            return existencia;

        }

        //Funcion para buscar una reservacion
        public DataTable buscar_una_reservacion(Reservacion datos_de_la_reservacion) 
        {
            DataTable datos;

            datos = funciones_De_La_Reservacio.Consultar_Una_Reservacion(datos_de_conexion, datos_de_la_reservacion);

            return datos;

        }

    }
}
