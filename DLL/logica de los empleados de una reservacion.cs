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
    public class logica_de_los_empleados_de_una_reservacion
    {

        Datos_login datos_de_conexion = new Datos_login();

        Funciones_para_agregar_un_empleado_a_una_reservacion funciones_Para_Agregar_Empleado_A_Una_Reservacion = new Funciones_para_agregar_un_empleado_a_una_reservacion();

        //Funcion para poder registraar un empleado a una reservacion
        public Boolean registrar_un_empleado_a_una_reservacion(Empleados_de_una_reservacion datos_del_servicio, Datos_login datos_de_conexion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Empleado_A_Una_Reservacion.Ingresar_Un_Empleado_a_una_Reservacion(datos_de_conexion, datos_del_servicio);

            return confirmacion;
        }

        //Funcion para traer todos los empleados de todas las reservaciones
        public DataTable traer_todos_los_empleados_de_una_reservacion()
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Empleado_A_Una_Reservacion.Consultar_todas_los_empleados_de_una_reservacion(datos_de_conexion);

            return datos;
        }

        //Funcion para traer los empleados de una reservacion
        public DataTable traer_los_empleados_de_una_reservacion(Empleados_de_una_reservacion datos_de_la_reservacion)
        {
            DataTable datos;

            datos = funciones_Para_Agregar_Empleado_A_Una_Reservacion.Consultar_Un_empleado_de_una_reservacion(datos_de_conexion, datos_de_la_reservacion);

            return datos;
        }

        //Funcion para eliminar un empleado de una reservacion
        public Boolean eliminar_un_empleado_de_una_reservacion(Empleados_de_una_reservacion datos_De_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Empleado_A_Una_Reservacion.borrar_un_empleado_de_una_reservacion(datos_de_conexion, datos_De_la_reservacion);

            return confirmacion;

        }

        //Funcion para actualizar datos de un empleado de una reservacion
        public Boolean actualizacion_de_datos_de_un_empleado_de_una_reservacion(Empleados_de_una_reservacion datos_de_la_reservacion)
        {
            Boolean confirmacion;

            confirmacion = funciones_Para_Agregar_Empleado_A_Una_Reservacion.Modificar_datos_de_un_empleado_de_una_reservacion(datos_de_conexion, datos_de_la_reservacion);

            return confirmacion;

        }


    }
}
