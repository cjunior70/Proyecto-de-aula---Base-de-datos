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
    public class logica_De_los_servicios_de_una_reservacion
    {

        Datos_login datos_de_conexion = new Datos_login();

        Funciones_para_agregar_servicio_a_una_reservacion funciones_Para_Agregar_Servicio_A_Una_Reservacion=new Funciones_para_agregar_servicio_a_una_reservacion();

        //Funcion para poder registraar un servicio a una reservacion
        public Boolean registrar_servicio_a_una_reservacion(Servicio_de_una_reservacion datos_del_servicio)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Reservacion.Ingresar_Un_Servicio_a_una_reservacion(datos_de_conexion,datos_del_servicio);

            return confirmacion;
        }

        //Funcion para traer todos los servicios y las reservaciones
        public DataTable traer_todos_los_servicios_de_las_reservaciones()
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Servicio_A_Una_Reservacion.Consultar_servicios_de_las_reservaciones(datos_de_conexion);

            return datos;
        }

        //Funcion para traer los servicios de una reservacion
        public DataTable traer_los_servicios_de_una_reservacion(Servicio_de_una_reservacion datos_de_la_reservacion)
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Servicio_A_Una_Reservacion.Consultar_Un_Servicio_de_una_reservacion(datos_de_conexion, datos_de_la_reservacion);

            return datos;
        }
         
        //Funcion para eliminar un servicio de una reservacion
        public Boolean eliminar_una_reservacion(Servicio_de_una_reservacion datos_De_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Reservacion.borrar_un_servicio_de_un_servico_de_una_reservacion(datos_de_conexion, datos_De_la_reservacion);

            return confirmacion;

        }

        //Funcion para actualizar datos de un servicio de una reservacion
        public Boolean actualizacion_de_datos_de_un_servicio_De_una_reservacion(Servicio_de_una_reservacion datos_de_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Servicio_A_Una_Reservacion.Modificar_datos_de_un_servicio_De_una_Reservacion(datos_de_conexion, datos_de_la_reservacion);

            return confirmacion;

        }

    }
}
